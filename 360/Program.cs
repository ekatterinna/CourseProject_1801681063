using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _360
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();
            bool result = input.All(Char.IsLetter);
            if (result == true)
            {
                Console.WriteLine("The string only contains letters");
            }
            else
            {
                Console.WriteLine("The string contains numbers");
            }
        }
    }
}
