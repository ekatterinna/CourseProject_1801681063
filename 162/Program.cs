using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162
{
    class Program

    {
        static double cor_pq(int x, int y)
        {
            return ((Math.Abs(x) * Math.Abs(y)) / (x + y));

        }
        public static void Main(string[] args)
        {
            int cor = 0;
            int cor1 = 0;
            int cor2 = 0;
            int cor3 = 0;
            int corpq = 0;
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter p: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter q: ");
            int q = int.Parse(Console.ReadLine());

            if (p >= -30 && p <= 30 && q >= -30 && q <= 30)
            {
                cor1 = p * (3 * q) / p + (3 * q);
                cor2 = (3 * p) * q / (3 * p) + q;
                cor3 = p * q / p + q;
                corpq = (cor1 - cor2) / cor3;

            }
            else
            {
                Console.WriteLine("Wrong values, must be between [-30,30]");
            }


            if (x != -y)
            {
                cor = ((x * y) / x + y);
            }
            else
            {
                cor = 0;
            }
            for (q = 10; q <= 50; q = q+4)
            {
                double c = cor_pq(p, q);
                if (c - (int)c == 0 && (int)c % 2 == 0)
                {
                    Console.WriteLine("cor(" + p + "," + q + ")=" + c);
                }
            }
        }
        
    }
}

