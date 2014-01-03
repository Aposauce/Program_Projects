using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of sides and cirucmradius");

            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            
            int sides = Convert.ToInt32(splitInput[0]);
            float circumradius = Convert.ToSingle(splitInput[1]);

            float perimeter = findPerimeter(sides, circumradius);

            Console.WriteLine("{0:N3}", perimeter);

        }

        static float findPerimeter(int n, float r)
        {
            int sides = n;
            Console.WriteLine("sides: " + sides);
            float radius = r;
            Console.WriteLine("radius: " + radius);

            float side = (float)(2 * r * Math.Sin(Math.PI / n));
            Console.WriteLine("side length: " + side);
            float perimeter = side * sides;
            Console.WriteLine("perimeter: " + perimeter);
            return perimeter;
        }

    }
}
