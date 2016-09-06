using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            int R = 15;
            int h = 8;
            double V = Math.Pow(R,2)*pi*h;
            double S = Math.Pow(R,2)*2*pi + Math.Pow(R,2)*2*pi;
            Console.Write("Объем цылиндра :  ");
            Console.WriteLine(V);
            Console.Write("Площадь цылиндра:  ");
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
