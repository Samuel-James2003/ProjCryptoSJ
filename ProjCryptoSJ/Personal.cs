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
            // Generate a random number between 5 and 10 and concatenate it to the key
            var random = new Random();
            key += random.Next(5, 10).ToString();
            key += random.Next(100, 1000).ToString();
            // Generate a random number between 1 and 128, convert it to an ASCII character, and concatenate it to the key
            key += (char)random.Next(1, 128);
            // Generate a random number between 1 and 128, convert it to an ASCII character, and concatenate it to the key
            key += (char)random.Next(1, 128);

        }

        public string Encrypt()
        {
            var sb = new StringBuilder();
            int offset = key[0];
            string salt = key.Substring(4);

            foreach (char item in crypt)
            {
                try
                {
                    sb.Append((char)(item + offset));
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Value is too large.");
                }


            }

            sb.Append(salt);
            return sb.ToString();

        }
        public string Decrypt(string encrypted)
        {
            var sb = new StringBuilder();
            int offset = key[0];
            // Process the entire encrypted string
            for (int i = 0; i < encrypted.Length; i++)
            {
                // Divide the character by the multiplier
                sb.Append((char)(encrypted[i] - offset));
            }


            sb.Remove(encrypted.Length - 2, 2);
            return sb.ToString();
        }


    }
}
