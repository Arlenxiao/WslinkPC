using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WsLinkPC
{
    public class IResult
    {
        private static HttpClient _client = null;
        public static HttpClient client
        {
            get
            {
                if (_client == null)
                {
                    _client = new HttpClient();
                    client.BaseAddress = new Uri("http://yun.wslink.cn/");
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                }
                return _client;
            }
            set { _client = value; }
        }

        /// <summary>
        /// 登录结果
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static LoninResult LoginIn(string username, string pwd)
        {
            var login = new { username = "test", password = "test" };

            var url = string.Format("Api/Login?username={0}&password={1}", username, pwd);

            var response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    string result = string.Empty;
                    var rs = response.Content.ReadAsStreamAsync().Result;
                    using (var sr = new StreamReader(rs, Encoding.UTF8))
                    {
                        result = sr.ReadToEnd();
                        rs.Close();
                    }

                    if (string.IsNullOrEmpty(result)) return new LoninResult { result = false };

                    return JsonHelp.JsonDeserialize<LoninResult>(result);
                }
                catch
                {
                    return new LoninResult { result = false };
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return new LoninResult { result = false };
            }
        }

        public static DevicesResult GetDevices()
        {
            var url = string.Format("Api/GetDevices");

            var response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    string result = string.Empty;
                    var rs = response.Content.ReadAsStreamAsync().Result;
                    using (var sr = new StreamReader(rs, Encoding.UTF8))
                    {
                        result = sr.ReadToEnd();
                        rs.Close();
                    }

                    if (string.IsNullOrEmpty(result)) return new DevicesResult { result = false };

                    return JsonHelp.JsonDeserialize<DevicesResult>(result);
                }
                catch
                {
                    return new DevicesResult { result = false };
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return new DevicesResult { result = false };
            }
        }
    }
}
