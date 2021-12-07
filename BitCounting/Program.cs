using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/526571aae218b8ee490006f4/train/csharp
namespace BitCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBits(0));
            Console.WriteLine(CountBits(4));
            Console.WriteLine(CountBits(7));
            Console.WriteLine(CountBits(9));
            Console.WriteLine(CountBits(10));

        }
        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).Count(x => int.Parse(x.ToString()) == 1);
        }

    }
}
