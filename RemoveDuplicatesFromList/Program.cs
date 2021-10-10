using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/57a5b0dfcf1fa526bb000118/train/csharp
namespace RemoveDuplicatesFromList
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int[] distinct(int[] a) => a.ToHashSet().ToArray();
    }
}
