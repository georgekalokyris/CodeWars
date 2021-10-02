using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codewars.com/kata/588f5a38ec641b411200005b/train/csharp

namespace DifferenceBetweenYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HowManyYears("1997/10/10", "2015/10/10"));
            Console.WriteLine(HowManyYears("1990/10/10", "2015/10/10"));
            Console.WriteLine(HowManyYears("2015/10/10", "1990/10/10"));
            Console.WriteLine(HowManyYears("1992/10/24", "2015/10/24"));
            Console.WriteLine(HowManyYears("2018/10/10", "2000/10/10"));
            Console.WriteLine(HowManyYears("2000/10/10", "2000/10/10"));
        }

        public static int HowManyYears(string date1, string date2)
        {
            int YearPartA = int.Parse(date1.Substring(0, 4));
            int YearPartB = int.Parse(date2.Substring(0, 4));

            return Math.Abs(YearPartA - YearPartB);
        }
    }
}
