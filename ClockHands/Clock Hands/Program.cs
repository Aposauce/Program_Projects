using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockHands
{
    public class ClockHands
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a 24 hour time (##:##)");
            try
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    string[] time = input.Split(':');
                    Console.WriteLine(findAngle(Convert.ToInt32(time[0]), Convert.ToInt32(time[1])));
                }

            }
            catch 
            {
                Console.WriteLine("Closing.");
                Console.ReadKey();
            }

        }

        public static double findAngle(int hour, int min)
        {
            double minuteAngle = min / 60.0 * 360.0;
            Console.WriteLine(minuteAngle);
            double hourAngle = hour / 24.0 * 360.0 + minuteAngle / 24.0;
            Console.WriteLine(hourAngle);

            return Math.Abs(hourAngle - minuteAngle);
        }
    }
}
