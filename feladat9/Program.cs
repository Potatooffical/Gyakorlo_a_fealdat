using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            double ker, ter;
            Console.Write("Add meg a négyzet hosszát:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            ker = 2 * (a+b);
            ter = a * b;

            Console.WriteLine($"A téglalap kerülete:{Math.Round(ker, 2)}");
            Console.WriteLine($"A téglalap területe:{Math.Round(ter, 2)}");

            Console.ReadKey();
        }
    }
}
