using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace One_Real_Estate___Database
{
    public class SHA256_Encryption
    {
        public static String ByteArrayToHexString(byte[] ba)
        {
            System.Text.StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }

        public String CreateSalt(int size) // Function to generate a random salt 
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public String GenerateSHA256Hash(String input, String salt) // Function to add user input and randomly generated salt
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);
            return ByteArrayToHexString(hash);
        }
    }
}