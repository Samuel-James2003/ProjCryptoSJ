using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCryptoSJ
{
    class Personal
    {
        
        private string key, crypt;

        public Personal(string crypt)
        {
            this.crypt = crypt;
            // Generate a random number between 1000 and 9999 and concatenate it to the key
            var random = new Random();
            key += random.Next(1000, 10000).ToString();

            // Generate a random number between 1 and 128, convert it to an ASCII character, and concatenate it to the key
            key += (char)random.Next(1, 128);

            // Generate a random number between 100 and 1000 and concatenate it to the key
            key += random.Next(100, 1000).ToString();
            
        }

        public string Encrypt()
        {
            var sb = new StringBuilder();
            int multiplyer = int.Parse(key.Substring(0, 4)), offset = int.Parse(key.Substring(4, 1));
            string salt = key.Substring(5);
            

            string mid = crypt.Substring(0,crypt.Length / 2);
            foreach (char item in mid)
            {
                sb.Append(item * multiplyer);
            }

            sb.Append(crypt.Substring(crypt.Length / 2));
            for (int i = 0; i < salt.Length; i += 2)
            {
                int num1 = int.Parse(salt[i].ToString());
                int num2 = int.Parse(salt[i + 1].ToString());
                char c = (num1 + num2 + offset < 128) ? (char)(num1 + num2 + offset) : (char)num1;
                sb.Append(c);
            }
            return sb.ToString();
            
        }
        public string Decrypt()
        {
            var sb = new StringBuilder();
            int multiplyer = int.Parse(key.Substring(0, 4)), offset = int.Parse(key.Substring(4, 1));
            string salt = key.Substring(5);

            string mid = crypt.Substring(0, crypt.Length / 2);
            int midLength = mid.Length;
            for (int i = 0; i < midLength; i++)
            {
                sb.Append(mid[i] / multiplyer);
            }

            sb.Append(crypt.Substring(crypt.Length / 2));
            for (int i = 0; i < salt.Length; i += 2)
            {
                int num1 = int.Parse(salt[i].ToString());
                int num2 = int.Parse(salt[i + 1].ToString());
                char c = (num1 + num2 + offset < 128) ? (char)(num1 + num2 + offset) : (char)num1;
                sb.Append((char)(c - offset));
            }
            return sb.ToString();
        }


    }
}
