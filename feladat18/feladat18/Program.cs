using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("adja meg a b es az a befogot:");
            double a=Convert.ToDouble(Console.ReadLine());
            double b=Convert.ToDouble(Console.ReadLine());
            double c=Math.Sqrt(a*a+b*b);
            Console.WriteLine($"atfogo:{c}");
            Console.ReadKey();
        }
    }
}
