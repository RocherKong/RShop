using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RShop.Infrastructure.Utilities
{
    /// <summary>
    /// 正在表达式帮助类
    /// </summary>
    public class RegexHelper
    {
        #region RegStr
        private const string EMail_Reg = @"^\w([a-z0-9]*[-_\.]?[a-z0-9]+)*@([a-z0-9]*[-_\.]?[a-z0-9]+)+[\.][a-z]{2,5}([\.][a-z]{1,2})?$";
        #endregion
        public static bool IsEMail(string emailStr)
        {
            return Regex.IsMatch(emailStr, EMail_Reg);
        }
    }
}
