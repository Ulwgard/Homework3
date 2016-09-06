using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 32;
            int y = 25;
            int z = 12;
            int answer = x+y+z/3;
            Console.Write("average       ");
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
