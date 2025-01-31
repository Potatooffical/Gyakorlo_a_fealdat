using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat16
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("adj meg egy számot ");
            double a =Convert.ToDouble( Console.ReadKey());
            double napev = a / 100 * 5;
            Console.WriteLine($"Jutalom{Math.Round(napev)}");
            Console.ReadKey();
        }
    }
}
