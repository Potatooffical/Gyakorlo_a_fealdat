using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat14
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int a, b;
            double szam;
            Console.Write("Add meg két számot:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            
            
            szam = a * b / 2;

            Console.WriteLine($"A Számtani közép:{szam}");
            

            Console.ReadKey();
        }
    }
}
