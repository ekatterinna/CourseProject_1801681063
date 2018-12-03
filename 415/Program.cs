using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _415
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int[] B = new int[n];
            int[] C = new int[n];
            Console.WriteLine("Въведете елементите на масив А");
            Vuvejdane(A);
            Console.WriteLine("Въведете елементите на масив В");
            Vuvejdane(B);
            Console.WriteLine("Въведете елементите на масив С");
            Vuvejdane(C);
            Console.WriteLine("Броят на елементите, отговарящи на условието на :");
            Console.WriteLine("Масив А: " + Product(A));
            Console.WriteLine("Масив В: " + Product(B));
            Console.WriteLine("Масив С: " + Product(C));
            int minPr = int.MaxValue;
            if (Product(A) < Product(B))
            {
                minPr = Product(A);
            }
            else
            {
                minPr = Product(B);
            }
            if (Product(C) < minPr)
            {
                minPr = Product(C);
            }
            Console.WriteLine(minPr);
            int t = 0, x = n;
            do
            {
                for (int i = 0; i < n; i++)
                {
                    C[t] = A[i] * B[x - 1];
                    x--;
                    t++;
                }

            } while (t != n);
            foreach (var item in C)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Vuvejdane(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static int Product(int[] a)
        {
            int pr = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 3 == 0 && a[i] > 0 && a[i] <= 50)
                {
                    pr = pr * a[i];
                }
            }
            return pr;
        }
    }
}
