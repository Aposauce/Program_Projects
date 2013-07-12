using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    public class FibonacciSequence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of Fibonacci sequence to generate to.  ");
            int sequence = int.Parse(Console.ReadLine());

            var fibSeq = new List<ulong>();
            ulong a = 0,
                b = 1;
            fibSeq.Add(a);
            if (sequence > 1)
            {
                fibSeq.Add(b);
                for (int i = 0; i < sequence - 2; i++)
                {
                    ulong temp = Fibonacci(a, b);
                    fibSeq.Add(temp);
                    a = b;
                    b = temp;
                }
            }

            fibSeq.ForEach(i => Console.Write(i + "\t"));
        }

        public static ulong Fibonacci(ulong a, ulong b)
        {
            return a + b;
        }
    }
}
