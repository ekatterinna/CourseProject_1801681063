namespace Тест_1_2_I_
{
    using System;
    class Program
    {
        static void Main()
        {
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            Console.Write("z=");
            double z = double.Parse(Console.ReadLine());
            double chislitel = Math.Pow(x, 7) * y * z - 3 * 3 * Math.Abs(x + Math.Pow(y, (1.0 / 4)));
            double znamenatel = Math.Pow(10, 7) + Math.Sqrt(Math.Log(4));
            double izraz = chislitel / znamenatel;
            Console.WriteLine("Стойността на израза е: {0} ", izraz);

        }
    }
}

