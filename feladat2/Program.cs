using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double hanyados;

            Console.Write("Első szám:");
            a=int.Parse(Console.ReadLine());
            Console.Write("Második szám:");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} * {b}={a * b}");
            hanyados = a / b;
            Console.WriteLine($"{a} / {b}={Math.Round(hanyados,2)}");
            
            Console.WriteLine("pogram vége");
            Console.ReadKey();
        }
    }
}
