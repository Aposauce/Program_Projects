using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Rotation
{
    public class MatrixRotation
    {
        static void Main(string[] args)
        {
            int[,] m = {{ 1  , 2  , 3  , 4  , 5  },
                        { 6  , 7  , 8  , 9  , 10 },
                        { 11 , 12 , 13 , 14 , 15 },
                        { 16 , 17 , 18 , 19 , 20 },
                        { 21 , 22 , 23 , 24 , 25 }};

            printArray(m);

            Console.WriteLine("Clockwise: ");
            printArray(rotate(m, true));
            Console.WriteLine("Counterclockwise: ");
            printArray(rotate(m, false));
        }

        public static int[,] rotate(int[,] matrix, bool clockwise)
        {
            int[,] rot = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (clockwise)
                    {
                        rot[i, matrix.GetLength(1) - 1 - j] = matrix[j, i];
                    }
                    else
                    {
                        rot[matrix.GetLength(0) - 1 - i, j] = matrix[j, i];
                    }
                }
            }

            return rot;
        }

        public static void printArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", array[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
