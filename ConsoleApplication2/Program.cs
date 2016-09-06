using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        { const double pi = 3.14;
            int r = 15;
            double answer;
            answer = Math.Pow(r,2)*pi;
            Console.Write("Площадь круга -      ");
            Console.WriteLine(answer);
            Console.ReadKey();

            
        }
    }
}
