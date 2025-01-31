using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aadjon meg egy számot");
            double a=Convert.ToDouble(Console.ReadLine());
            double b = a * 1.8 + 32;
            Console.WriteLine($"az adat celciusról Fahrenheitre: {Math.Round(b,2)}");
            Console.ReadKey();
        }
    }
}
