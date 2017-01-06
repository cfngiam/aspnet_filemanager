using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace aspnet_filemanager.Helpers
{
    public class Cryptography
    {
        /// <summary>
        /// Cria o HASH do password 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string CreateHash(string password)
        {
            string salt = ConfigurationManager.AppSettings.Get("SALT_STRING");
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);

            return Convert.ToBase64String(SHA512.Create().ComputeHash(bytes));
        }
    }
}