using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/56b1f01c247c01db92000076/train/csharp
namespace DoubleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleChar("illuminati"));
        }

        public static string DoubleChar(string s)=> string.Concat(s.Select(x => new string(x, 2)));
    }


}
