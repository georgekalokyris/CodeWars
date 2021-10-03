using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvenOrOdd(2));
            Console.WriteLine(EvenOrOdd(1));
            Console.WriteLine(EvenOrOdd(0));
            Console.WriteLine(EvenOrOdd(7));
            Console.WriteLine(EvenOrOdd(-1));
        }

        public static string EvenOrOdd(int number) => number % 2 == 0 ? "Even" : "Odd";
    }
}
