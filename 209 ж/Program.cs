using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _209_ж
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = 0;
            for (int i = 0; i < 132; i++)
            {
                number = rand.Next(0, 132);

                if (number >= 100 || number < 26)
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadKey();
        }
    }
}
