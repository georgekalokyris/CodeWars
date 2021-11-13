using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codewars.com/kata/54466996990c921f90000d61/train/csharp

namespace MonotoneTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsMonotone(Enumerable.Range(1, 5).Reverse().ToArray())); //False


        }

        public static bool IsMonotone(int[] arr)
        {
            return arr.OrderBy(i => i).SequenceEqual(arr);

        }
        //Long Solution
        //public static bool IsMonotone(int[] arr)
        //{
        //    List<int> prev = new List<int>();
        //    if (arr.Length == 1 || arr.Length == 0 || arr.All(x => x == arr[0]))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        for(int i = 0; i < arr.Length; i++)
        //        {
        //            prev.Add(arr[i]);
        //            if (prev.Any(x => x > arr[i + 1])) return false;
        //        }
        //    }
        //    return true;
        //}`
    }
}
