using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace felatdat5
{
    internal class Program
    {
        static void Main(string[] args)
        {//bekéri egy kör sugarát és kiírja a kerületét és a területét 4 tizedes pontossággal.
         //𝐾 = 2 ∗ 𝑟 ∗ 𝜋
         //𝑇 = 𝑟
         //2
         //∗ 


            int r;
            double ker, ter;
            double pi = Math.PI;
            Console.Write("Add meg a kör sugarat:");
            r = int.Parse(Console.ReadLine());

            ker = 2 * r * pi;
            ter = r * r * pi;

            Console.WriteLine($"A kör kerülete:{Math.Round(ker),4}");
            Console.WriteLine($"A kör területe:{Math.Round(ter),4}");

            Console.ReadKey();
        }
    }
}
