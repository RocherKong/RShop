using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RShop.Infrastructure.Utilities
{
    public class MD5Helper
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="encryptStr">加密字符串</param>
        /// <param name="privateKey">私钥</param>
        /// <param name="inputCharset">编码格式</param>
        /// <returns></returns>
        public static string Encrypt(String encryptStr, String privateKey = "", string inputCharset = "utf-8")
        {
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                StringBuilder result = new StringBuilder(32);
                encryptStr = encryptStr + privateKey;
                byte[] t = md5.ComputeHash(Encoding.GetEncoding(inputCharset).GetBytes(encryptStr));
                for (int i = 0; i < t.Length; i++)
                {
                    result.Append(t[i].ToString("x").PadLeft(2, '0'));
                }
                return result.ToString();
            }
        }
    }
}
