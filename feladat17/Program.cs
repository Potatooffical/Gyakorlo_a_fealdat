using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a,b;
            double d;
            Console.Write("Add meg két számot:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            d = Math.Sqrt((a - b) * (a - b) * (Math.Pow(b, 2)) - (Math.Pow(a, 2)) * (Math.Pow(b, 2)) - (Math.Pow(a, 2)));

            Console.WriteLine($"A Számtani közép:{d}");


            Console.ReadKey();
        }
    }
}
