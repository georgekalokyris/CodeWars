using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/5a3dd29055519e23ec000074
namespace CheckTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int CheckExam(string[] arr1, string[] arr2)
        {
            int score = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                score += arr1[i] == arr2[i] ? 4 : arr2[i] == "" ? 0 : -1;
            }
            return score < 0 ? score = 0 : score;
        }
    }
}
