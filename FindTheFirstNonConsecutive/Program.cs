using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/58f8a3a27a5c28d92e000144/train/csharp
namespace FindTheFirstNonConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonConsecutive(new int[] { 1, 2, 3, 4, 6, 7, 8 }));
        }

        public static object FirstNonConsecutive(int[] arr)
        {
            List<int> myArr = Enumerable.Range(arr[0], arr.Length).ToList();
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != myArr[i]) return arr[i];
            }

            return null;
        }

    }
}
