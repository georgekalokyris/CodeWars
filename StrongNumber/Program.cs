using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/5a4d303f880385399b000001/train/csharp
namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrongNumber(1));
            Console.WriteLine(StrongNumber(2));
            Console.WriteLine(StrongNumber(145));
            Console.WriteLine(StrongNumber(7));

        }

        public static string StrongNumber(int number)
        {

            int[] nums = new int[number.ToString().Length];
            for (int i = 0; i < number.ToString().Length; i++)
            {
                nums[i] = int.Parse(number.ToString().ToCharArray()[i].ToString());
            }


            int TotalSum = 0;
            foreach (var item in nums)
            {
                int factorial = 1;

                for (int i = 1; i <= item; i++)
                {
                    factorial = i * factorial;

                }
                TotalSum += factorial;
            }

            return TotalSum == number?"STRONG!!!!":"Not Strong !!";
        }

        /* Or just do the following:
          private static int Factorial(int n) => n == 0 ? 1 : n * Factorial(n - 1);
  
          public static string StrongNumber(int number)
          {
              return number == number.ToString().Sum(n => Factorial(int.Parse(n.ToString())))
                  ? "STRONG!!!!"
                  : "Not Strong !!";
          }
        */
    }
}
