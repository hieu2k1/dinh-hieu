using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01
{
    class EX2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so thu 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu 3: ");
            int c = int.Parse(Console.ReadLine());

            int max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine("max trong 3 {0},{1},{2} so la{3} ", a, b, c, max);
            Console.ReadKey();
        }

    }
}
