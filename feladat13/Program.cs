using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bekér egy (5 Ft) megfelelőre kerekíti.
            int a;
            a = int.Parse(Console.ReadLine());
            a = 5 * a;
            Console.WriteLine($"{Math.round(a,2)}");
        }
    }
}
