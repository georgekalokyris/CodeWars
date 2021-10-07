using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/55192f4ecd82ff826900089e/train/csharp
namespace Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(2));
            Console.WriteLine(Divide(3));
            Console.WriteLine(Divide(4));
            Console.WriteLine(Divide(5));
            Console.WriteLine(Divide(6));
        }

        public static bool Divide(int weight) => weight % 2 == 0 && weight > 2 ? true : false;
    }
}
