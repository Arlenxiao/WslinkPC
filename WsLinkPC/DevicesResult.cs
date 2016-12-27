using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WsLinkPC
{
    public class DevicesResult
    {
        /// <summary>
        /// 请求结果
        /// </summary>
        public bool result { get; set; }
        /// <summary>
        /// 设备集合
        /// </summary>
        public List<DeviceItem> data { get; set; }
    }

    /// <summary>
    /// 设备类型
    /// </summary>
    public class DeviceItem
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 设备类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 设备状态
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// 设备公开类型
        /// </summary>
        public int Public { get; set; }
        /// <summary>
        /// 设备数据
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// 设备标签
        /// </summary>
        public string Labels { get; set; }
        /// <summary>
        /// 设备扩展信息
        /// </summary>
        public Extends Extends { get; set; }
    }

    /// <summary>
    /// 扩展数据类
    /// </summary>
    public class Extends
    {
        /// <summary>
        /// WIFI信息
        /// </summary>
        public string WiFi { get; set; }
        /// <summary>
        /// 绑定类型
        /// </summary>
        public int BindKind { get; set; }
        /// <summary>
        /// 显示信息
        /// </summary>
        public string Title { get; set; }
    }

}
