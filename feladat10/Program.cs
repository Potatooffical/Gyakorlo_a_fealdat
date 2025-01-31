using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            double fel, ter;
            Console.Write("Add meg a négyzet hosszát:");
            a = int.Parse(Console.ReadLine());

            fel = 6 * a * a ;
            ter = a * a * a ;

            Console.WriteLine($"A négyzet kerülete:{Math.Round(fel, 2)}");
            Console.WriteLine($"A négyzet területe:{Math.Round(ter, 2)}");

            Console.ReadKey();
        }
    }
}
