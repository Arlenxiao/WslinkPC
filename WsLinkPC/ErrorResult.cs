﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WsLinkPC
{
    public class ErrorResult
    {
        /// <summary>
        /// 请求结果
        /// </summary>
        public bool result { get; set; }
        /// <summary>
        /// 010001FA14
        /// </summary>
        public string error { get; set; }
    }
}
