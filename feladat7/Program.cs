using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aadjon meg egy számot");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = (a-32)*0.56;
            Console.WriteLine($"az adat Fahrenheitról celciusra: {Math.Round(b,2)}");
            Console.ReadKey();
        }
    }
}
