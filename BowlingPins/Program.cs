using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingPins
{
    //https://www.codewars.com/kata/585cf93f6ad5e0d9bf000010/train/csharp
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray0 = new int[] {1,2,3};
            Console.Write(BowlingPins(testArray0));
            Console.WriteLine();
            int[] testArray1 = new int[] { 3, 5, 9 };
            //Console.WriteLine(BowlingPins(testArray1));
        }

        public static string BowlingPins(int[] arr)
        {
            string Pin = "I";
            string NoPin = " ";

            string[] Bowl1 = new string[7];
            string[] Bowl2 = new string[7];
            string[] Bowl3 = new string[7];
            string[] Bowl4 = new string[7];

            //Pre-Populate all
            for (int i = 0; i < 7; i++)
            {
                if (i == 0 || i == 2 || i == 4 || i == 6) Bowl4[i] = Pin; else Bowl4[i] = NoPin;
                if (i == 1 || i == 3 || i == 5) Bowl3[i] = Pin; else Bowl3[i] = NoPin;
                if (i == 2 || i == 4) Bowl2[i] = Pin; else Bowl2[i] = NoPin;
                if (i == 3) Bowl1[i] = Pin; else Bowl1[i] = NoPin;
            }

            //Bowl4
            if (arr.Contains(7))  Bowl4[0] = NoPin;
            if (arr.Contains(8))  Bowl4[2] = NoPin;
            if (arr.Contains(9))  Bowl4[4] = NoPin;
            if (arr.Contains(10)) Bowl4[6] = NoPin;

            //Bowl3
            if (arr.Contains(4)) Bowl3[1] = NoPin;
            if (arr.Contains(5)) Bowl3[3] = NoPin;
            if (arr.Contains(6)) Bowl3[5] = NoPin;

            //Bowl2
            if (arr.Contains(2)) Bowl2[2] = NoPin;
            if (arr.Contains(3)) Bowl2[4] = NoPin;

            //Bowl1
            if (arr.Contains(1)) Bowl1[3] = NoPin;

            return string.Join("\n", string.Join("",Bowl4), string.Join("", Bowl3), string.Join("", Bowl2), string.Join("", Bowl1));
        }


        //Another smart solution is
        //public class Bowling
        //{
        //    public string BowlingPins(int[] arr)
        //      => string.Format("{6} {7} {8} {9}\n {3} {4} {5} \n  {1} {2}  \n   {0}   ", Enumerable.Range(1, 10).Select(x => arr.Contains(x) ? " " : "I").ToArray());
        //}
    }
}


