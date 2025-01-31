using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat4
{
    internal class Program
    {
        static void Main(string[] args)
        {//4. mm-ben megadott értéket bontsunk méterre, deciméterre, centiméterre, milliméterre!
            int mm;
            Console.Write("add meg az adot merteket mm-ben:");
            mm =int.Parse(Console.ReadLine());
            Console.WriteLine($"ugyan ez a mennyiseg {mm}-ben megadva Deciméterre {mm / 10}");
            Console.WriteLine($"ugyan ez a mennyiseg {mm}-ben megadva Méterre {mm / 100}");

            Console.WriteLine("a pogram vége");
            Console.ReadKey();
        }
    }
}
