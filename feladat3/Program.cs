using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dl;
            //Feladat Deciliterben megadott térfogatot bontsunk hektoliter, liter, deciliter egységekre!
            Console.Write("Add meg az adatot dl-ben:");
            dl =int.Parse(Console.ReadLine());
            Console.WriteLine($"ugyan ez a mennyiseg {dl}-ben megadva literre {dl / 10}");
            Console.WriteLine($"ugyan ez a mennyiseg {dl}-ben megadva literre {dl / 1000}");

            Console.WriteLine("pogram vége");
            Console.ReadKey();
        }
    }
}
