using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("első szám:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("második szám:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a+b}");
            Console.WriteLine($"{a}-{b}={a-b}");



            Console.WriteLine("a pogramm vége");
            Console.ReadKey();
        }
    }
}
