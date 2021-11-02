using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/55b051fac50a3292a9000025/train/csharp
namespace FilterTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(FilterString("a123fb"));
        }
        public static int FilterString(string s)
        {
            return int.Parse(string.Concat(s.Where(x => char.IsNumber(x))));
            //or just     return int.Parse(new String(s.Where(Char.IsDigit).ToArray()));
        }

    }
}
