using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            Console.Write("num 1 - ");
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("num 2 - ");
            int.TryParse(Console.ReadLine(), out b);

            sum = a + b;
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
