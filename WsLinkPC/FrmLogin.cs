using DSkin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WsLinkPC
{
    public partial class FrmLogin : Skin_VS_Dark
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private async void Login()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://yun.wslink.cn/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var login = new { username = "test", password = "test" };

            var url = string.Format("Api/Login?username={0}&password={1}", txt_username.Text, txt_password.Text);

            var response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = string.Empty;
                var rs = await response.Content.ReadAsStreamAsync();
                using (var sr = new StreamReader(rs, Encoding.UTF8))
                {
                    result = sr.ReadToEnd();
                    rs.Close();
                }

                if (string.IsNullOrEmpty(result)) return;

                try
                {
                    var msg = JsonHelp.JsonDeserialize<WslinkMessage>(result);

                    if (msg.result)
                    {
                        FrmRight main = new FrmRight();
                        main.Show();
                        this.Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("登录失败");
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        public class WslinkMessage
        {
            /// <summary>
            /// 返回结果
            /// </summary>
            public bool result { get; set; }

            /// <summary>
            /// 返回数据
            /// </summary>
            public Object data { get; set; }
        }

        /// <summary>
        ///  在VS中需要添加引用System.Runtime.Serialization.Json
        /// </summary>
        public class JsonHelp
        {
            /// <summary>
            /// json序列化（非二进制方式）
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="t"></param>
            /// <returns></returns>
            public static string JsonSerializer<T>(T t)
            {
                //序列化
                var js = new DataContractJsonSerializer(typeof(T));
                string json = string.Empty;
                using (MemoryStream ms = new MemoryStream())
                {
                    //将序列化之后的Json格式数据写入流中
                    js.WriteObject(ms, t);
                    ms.Position = 0;
                    //从0这个位置开始读取流中的数据
                    StreamReader sr = new StreamReader(ms, Encoding.UTF8);
                    json = sr.ReadToEnd();
                    sr.Close();
                    ms.Close();
                }
                return json;
            }

            /// <summary>
            /// json反序列化（非二进制方式）
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="jsonString"></param>
            /// <returns></returns>
            public static T JsonDeserialize<T>(string jsonString)
            {
                //反序列化
                using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonString)))
                {
                    DataContractJsonSerializer deseralizer = new DataContractJsonSerializer(typeof(T));
                    T model = (T)deseralizer.ReadObject(ms);// //反序列化ReadObject
                    return model;
                }

            }

        }       
    }
}
