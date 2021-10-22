using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codewars.com/kata/5a53a17bfd56cb9c14000003/train/csharp

namespace DisariumNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DisariumNumber(89));
            Console.WriteLine("---------");
            Console.WriteLine(DisariumNumber(564));
            Console.WriteLine("---------");

            Console.WriteLine(DisariumNumber(1024));
            Console.WriteLine("---------");

            Console.WriteLine(DisariumNumber(135));
        }

        public static string DisariumNumber(int number)
        {
            double total = 0;
            char[] numArr = number.ToString().ToCharArray();

            for (int i = 1; i <= numArr.Length; i++)
            {
                
                total += Math.Pow(int.Parse(numArr[i-1].ToString()), i);
            }
            return total == number ? "Disarium !!" : "Not !!";
        }
        /* or just
         
        public static string DisariumNumber(int number)
        {
         return number.ToString().Select((c, i) => Math.Pow(int.Parse(c.ToString()), ++i)).Sum() == number
             ? "Disarium !!"
             : "Not !!";
        }
        */

    }
}
