using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits_DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot(16));
        }

        public static int DigitalRoot(long n)
        {
            if (n <= 9)
            {
                Int32.TryParse(n.ToString(), out int final);
                return final;
            }
            else
            {
                char[] chArr = n.ToString().ToArray();
                int[] intArr = new int[chArr.Length];
                for (int i = 0; i < chArr.Length; i++)
                {
                    intArr[i] = int.Parse(chArr[i].ToString());

                }
                return DigitalRoot(intArr.Sum());
            }
        }

        public static double Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);//Recursive call
        }
    }
}
