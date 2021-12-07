using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/55f2b110f61eb01779000053/train/csharp
namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(0, 1));
            Console.WriteLine(GetSum(0, -1));

            Console.WriteLine(string.Join("|",Enumerable.Range(0, 2)));
        }

        public static int GetSum(int a, int b)
        {
            return a == b ? a : a < b ? Enumerable.Range(a, b-a+1).Sum() : Enumerable.Range(b, a-b+1).Sum();
        }
    }
}
