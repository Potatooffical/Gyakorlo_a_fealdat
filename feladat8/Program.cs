using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            double ker, ter;
            Console.Write("Add meg a négyzet hosszát:");
            a = int.Parse(Console.ReadLine());

            ker = 4 * a;
            ter = a * a;

            Console.WriteLine($"A négyzet kerülete:{Math.Round(ker,2)}");
            Console.WriteLine($"A négyzet területe:{Math.Round(ter,2)}");

            Console.ReadKey();
        }
    }
}
