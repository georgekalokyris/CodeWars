using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/570a6a46455d08ff8d001002/csharp
namespace NoZerosForHeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NoBoringZeros(1450));
            Console.WriteLine(NoBoringZeros(960000));
            Console.WriteLine(NoBoringZeros(1050));
            Console.WriteLine(NoBoringZeros(-1050));
        }

        public static int NoBoringZeros(int n)
        {
            return (n == 0) ? 0 : Convert.ToInt32(n.ToString().TrimEnd('0'));
        }

    }
}
