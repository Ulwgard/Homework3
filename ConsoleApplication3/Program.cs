using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;
            int answer = x += y - x++ * z;
            int answer2 = z = --x - y * 5;
            int answer3 = y /= x + 5 % z;
            int answer4 = z = x++ + y * 5;
            int answer5 = x = y - x++ * z;
            Console.WriteLine(answer);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            Console.WriteLine(answer5);
            Console.ReadKey();
        }
    }
}
