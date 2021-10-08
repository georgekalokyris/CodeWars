using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codewars.com/kata/56684677dc75e3de2500002b/train/csharp

namespace ComfortableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ComfortableWord("yams"));
            Console.WriteLine(ComfortableWord("odor"));
            Console.WriteLine(ComfortableWord("their"));

            Console.WriteLine(ComfortableWord("leisure"));
            Console.WriteLine(ComfortableWord("touts"));
            Console.WriteLine(ComfortableWord("test"));
        }
        public static bool ComfortableWord(string word)
        {
            char[] Left = new char[15] { 'q', 'w', 'e', 'r', 't', 'a', 's', 'd', 'f', 'g', 'z','x', 'c', 'v', 'b' };
            char[] Right = new char[11] { 'y', 'u', 'i', 'o', 'p', 'h', 'j', 'k', 'l', 'm', 'n' };
            char[] wordArr = word.ToCharArray();
            bool result = false;
            for (int i = 0; i < wordArr.Length-1; i++)
            {
                if(Left.Any(x=> x == wordArr[i]) && Right.Any(x=> x == wordArr[i+1]) || Right.Any(x => x == wordArr[i]) && Left.Any(x => x == wordArr[i + 1]))
                {
                    result = true;
                }
                else
                {
                    return false;
                }
            }

            return result;
        }

    }
}
