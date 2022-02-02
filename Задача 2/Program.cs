using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            CalcSV(N);
            Console.ReadKey();
        }
        static void CalcSV(int a)
        {
            double S = 6 * Math.Pow(a, 2);
            double V = Math.Pow(a, 3);
            Console.WriteLine("Площадь поверхности куба = {0}",S);
            Console.WriteLine("Объем куба = {0}", V);

        }
        

    }

}
