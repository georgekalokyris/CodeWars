using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SumOfIntegersInAString
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SumOfIntegersInString("12.4"));
            Console.WriteLine(SumOfIntegersInString("h3ll0w0rld"));
            Console.WriteLine(SumOfIntegersInString("2 + 3 = "));
            Console.WriteLine(SumOfIntegersInString("Our company made approximately 1 million in gross revenue last quarter."));
            Console.WriteLine(SumOfIntegersInString("The Great Depression lasted from 1929 to 1939."));
            Console.WriteLine(SumOfIntegersInString("Dogs are our best friends."));
            Console.WriteLine(SumOfIntegersInString("C4t5 are 4m4z1ng."));
            Console.WriteLine(SumOfIntegersInString("The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog"));
        }

        public static int SumOfIntegersInString(string s)
        {
            int sum = 0;
            string nums = "0";
            s.Replace('.', ' ');
            for(int i=0; i<s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                {
                    nums += s[i].ToString();
                }
                else
                {
                    sum += int.Parse(nums);
                    nums = "0";
                }
            }
            sum += int.Parse(nums);
            return sum;
        }

        /* Or just save some time with Regex
          
        public static int SumOfIntegersInString(string s)
        {
        return Regex.Matches(s, "\\d+").Sum(x => int.Parse(x.Value));
        }

         */
    }
}
