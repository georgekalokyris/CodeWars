using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codewars.com/kata/51c8e37cee245da6b40000bd/train/csharp

namespace StripComments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));
            Console.WriteLine(StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));


            //StringArrayToCharArray(new string[] { "#", "!" });
        }

        public static string StripComments(string text, string[] commentSymbols)
        {
            //Break the string into lines
            string[] textLines = text.Split('\n');

            char[] charArr = StringArrayToCharArray(commentSymbols);

            string final = "";

            //Take the substring of each line till the symbol 
            foreach (var line in textLines)
            {
                if (commentSymbols.Any(line.Contains))
                {
                    final += line.Substring(0, line.IndexOfAny(charArr)).TrimEnd() + "\n";
                }
                else
                {
                    final += line.TrimEnd() + "\n";
                }
                
            }

            if (final.EndsWith("\n"))
            {
                return final;
            }
            else
            {
                return final.TrimEnd();
            }
        }


        public static char[] StringArrayToCharArray(string [] stringArr)
        {
            if (stringArr.Length > 0)
            {
                char[] charArr = new char[stringArr.Length];
                for (int i = 0; i < stringArr.Length; i++)
                {
                    charArr[i] = stringArr[i][0];
                }
                return charArr;
            }
            else
            {
                return new char[0];
            }
        }

       

    }
}
