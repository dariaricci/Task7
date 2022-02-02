using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int z2 = Convert.ToInt32(Console.ReadLine());

            if (SumTriangle(x1, y1, z1) > SumTriangle(x2, y2, z2))
                Console.WriteLine("Площадь первого треугольника больше");
            else
                Console.WriteLine("Площадь второго треугольника больше");
            Console.ReadKey();
        }
        static double SumTriangle(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a)*(p - b)*(p - c));
            return s;
        }
    }
}
