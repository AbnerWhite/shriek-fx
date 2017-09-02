﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Shriek.WebApi.Proxy
{
    /// <summary>
    /// 表示Get请求
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class HttpGetAttribute : HttpMethodAttribute
    {
        /// <summary>
        /// Get请求
        /// </summary>
        /// <param name="path">相对路径</param>
        /// <exception cref="ArgumentNullException"></exception>
        public HttpGetAttribute(string path)
            : base(HttpMethod.Get, path)
        {
        }
    }
}
