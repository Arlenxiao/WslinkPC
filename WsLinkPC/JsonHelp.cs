using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace WsLinkPC
{
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
