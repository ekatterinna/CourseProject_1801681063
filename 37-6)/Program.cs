using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, x, t, v, z;
            do
            {
                Console.WriteLine("Input c:");
                c = double.Parse(Console.ReadLine());
            } while (!((0.17 * Math.Pow(c, 3)) - 1 <= 0));

            Console.WriteLine("x= ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("t= ");
            t = double.Parse(Console.ReadLine());
            Console.WriteLine("v= ");
            v = double.Parse(Console.ReadLine());
            Console.WriteLine("z= ");
            z = double.Parse(Console.ReadLine());

            double n = (0.17 * Math.Pow(c, 3)) - 1;
            double result = n + z * ((-x) + t) + (-v);
            Console.WriteLine("Result is: " + result);
            Console.ReadKey();

        }

    }
}