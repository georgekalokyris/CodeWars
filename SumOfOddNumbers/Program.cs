using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/55fd2d567d94ac3bc9000064/solutions/csharp
namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(rowSumOddNumbers(1));
            Console.WriteLine(rowSumOddNumbers(2));
            Console.WriteLine(rowSumOddNumbers(3));
            Console.WriteLine(rowSumOddNumbers(42)); //74088
        }

        public static long rowSumOddNumbers(long n)
        {
            List<long> Lista = new List<long>();

            int prev = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (prev == 1) Lista.Add(prev);
                    else Lista.Add(prev);
                    prev += 2;
                }
            }

            List<long> final = new List<long>();
            Lista.Reverse();
            final.AddRange(Lista.Take((int)n).ToList());

            return final.Sum();

            //or just n*n*n
        }
    }
}
