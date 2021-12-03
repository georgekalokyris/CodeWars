using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/570597e258b58f6edc00230d/train/csharp
namespace RemoveFirstandLastCharPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Array("")); //null
            Console.WriteLine(Array("1")); //null
            Console.WriteLine(Array("1, 3")); //null
            Console.WriteLine(Array("1,2,3")); //2
            Console.WriteLine(Array("1,2,3,4")); //2 3
        }
        public static string Array(string s)
        {
            string[] chars = String.Join("",s.Where(x => !char.IsWhiteSpace(x))).Split(',').ToArray();
            return chars.Length < 3 ? null : String.Join(" ", chars.Skip(1).Take(chars.Length - 2));
        }
    }
}
