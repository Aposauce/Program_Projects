using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereCipher
{
    public class VigenereCipher
    {
        public static void Main(string[] args)
        {
            string key = "REDDIT";
            string message = "TODAYISMYBIRTHDAY";
            string ciph = VigenereCipher.crypt(message, key, true);
            Console.WriteLine(ciph);
            Console.WriteLine(VigenereCipher.crypt(ciph, key, false));
        }

        public static string crypt(string message, string key, bool encrypt)
        {
            message = message.ToUpper();
            key = key.ToUpper();
            string cipher = "";

            for (int i = 0; i < message.Length; i++)
            {
                if(encrypt)
                    cipher += (char)(((message[i] - 65) + (key[i % key.Length] - 65)) % 26 + 65);
                else
                    cipher += (char)(((message[i] - 65) - (key[i % key.Length] - 65) + 26) % 26 + 65);
            }

            return cipher;
        }
    }
}
