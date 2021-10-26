using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreatePhoneNumber((new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }))); //ExpectedResult = "(123) 456-7890")
            Console.WriteLine(CreatePhoneNumber((new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }))); //ExpectedResult = "(111) 111-1111")
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            StringBuilder sb = new StringBuilder("(", numbers.Length + 2);
            sb.Append(string.Concat(numbers.Take(3)));
            sb.Append(") ");
            sb.Append(string.Concat(numbers.Skip(3).Take(3)));
            sb.Append("-");
            sb.Append(string.Concat(numbers.Skip(6).Take(4)));
            return sb.ToString();
        }
    }
}
