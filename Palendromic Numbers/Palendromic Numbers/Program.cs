using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicNumbers
{
    public class PalindromicNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Palindromic number test:");
            try
            {
                while (true)
                {
                    Console.WriteLine(isPalendromic(Convert.ToInt32(Console.ReadLine())));
                }
            }
            catch 
            {
                Console.WriteLine("Closing.");
                Console.ReadKey();
            }

        }

        public static bool isPalendromic(int num)
        {
            int n = num;
            int reverse = 0;
            while(n != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + n % 10;
                n = n / 10;
            }

            return num == reverse;
        }
    }
}
