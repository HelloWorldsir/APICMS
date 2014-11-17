using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonCustom
{
    public class EncodeHelp
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string Md5Help(string str)
        {
            //创建MD5 实例 
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            //将输入的字符串转换成字节数组
            byte[] bt = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));
            //加密后的字符串为strMD5
           string result = BitConverter.ToString(bt);
           return result;
        }
    }
}
