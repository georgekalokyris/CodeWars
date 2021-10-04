using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/583710ccaa6717322c000105/train/csharp
namespace SimpleMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(1));
            Console.WriteLine(Multiply(10));
        }

        public static int Multiply(int x) => x % 2 == 0 ? x * 8 : x * 9;
        
    }
}
