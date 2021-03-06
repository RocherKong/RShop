﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RShop.Infrastructure.WebApi.Filter
{
    /// <summary>
    /// 过滤Api Token 验证标识
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class NoneTokenAttribute : Attribute
    {
    }
}
