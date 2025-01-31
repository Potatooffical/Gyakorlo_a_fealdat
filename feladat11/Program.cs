using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            double fel, ter;
            Console.Write("Add meg a téglatest oldalit:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());  
            c = int.Parse(Console.ReadLine());  
            fel = 2 * a * b +2 * a * c +2 * b * c;
            ter = a * b * c;

            Console.WriteLine($"A téglatest kerülete:{Math.Round(fel, 3)}");
            Console.WriteLine($"A téglatest területe:{Math.Round(ter, 3)}");

            Console.ReadKey();
        }
    }
}
