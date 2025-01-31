using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Készítsen programot, amely segít a pénztárosnak a papírpénzek értékének megszámolásánál!
            //Kérje be melyik bankjegyből(500, 1000, 2000, 5000, 10000, 20000) hány darab van, és a
            //végén adja meg az összes bevételt.
            Console.WriteLine("adja meg az eréket:");
            int a=Convert.ToInt32(Console.ReadLine())*500;  
            int b=Convert.ToInt32(Console.ReadLine())*1000;  
            int c=Convert.ToInt32(Console.ReadLine())*2000;  
            int d=Convert.ToInt32(Console.ReadLine())*5000;  
            int e=Convert.ToInt32(Console.ReadLine())*10000;  
            int f=Convert.ToInt32(Console.ReadLine())*20000;
            
            int ossz=a+b+c+d+e+f;

            Console.WriteLine($"pénztár osszege:{ossz");
            
            
            Console.ReadKey();
        }
    }
}
