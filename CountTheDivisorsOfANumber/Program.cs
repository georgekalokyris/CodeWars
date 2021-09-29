using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheDivisorsOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divisors(1));
            Console.WriteLine(Divisors(10));
            Console.WriteLine(Divisors(11));
            Console.WriteLine(Divisors(54));
        }
        public static int Divisors(int n)
        {
            int divisors = 0;
            for (int i = n; i > 0; i--)
            {
                divisors += n % i == 0 ? 1 : 0;
            }
            return divisors;
        }
    }
}
