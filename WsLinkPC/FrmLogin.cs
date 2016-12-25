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

                        //帐号信息
                        Account.User = msg.data as User;
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

    }
}
