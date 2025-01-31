using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m, r ;
            double fel, ter;
            Console.Write("Add meg a henger sugarát:");
            double pi = Math.PI;
            m = int.Parse(Console.ReadLine());
            r = int.Parse(Console.ReadLine());
            pi = int.Parse(Console.ReadLine());
            fel = 2* r *m*(r+m);
            ter = pi * r * m ;

            Console.WriteLine($"A henger kerülete:{Math.Round(fel, 2)}");
            Console.WriteLine($"A henger területe:{Math.Round(ter, 2)}");

            Console.ReadKey();
        }
    }
}
