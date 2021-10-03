using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableMagic25TakethefirstNelements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 3));
            Console.WriteLine(Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 0));
            Console.WriteLine(Take(new int[] { }, 3));
        }

        public static int[] Take(int[] arr, int n) => arr.Take(n).ToArray();
    }
}
