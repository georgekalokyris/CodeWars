using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097/train/csharp
namespace CenturyFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Сentury(1705)); //18
            Console.WriteLine("--------------");
            Console.WriteLine(Сentury(1900)); //19
            Console.WriteLine("--------------");
            Console.WriteLine(Сentury(1601)); //17
            Console.WriteLine("--------------");
            Console.WriteLine(Сentury(2000)); //20
        }

        public static int Сentury(int year)
        {
            return (year / 100) + ((year % 100 == 0) ? 0 : 1);
        }
    }
}
