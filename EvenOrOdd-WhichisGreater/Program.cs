using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd_WhichisGreater
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static string EvenOrOdd(string str)
        {
            int even = 0;
            int odd = 0;
            foreach (var num in str)
            {
                Int32.TryParse(num.ToString(), out int intnum);
                
                if (intnum % 2 == 0) even += intnum;
                else odd += intnum;
            }

            return even > odd ? "Even is greater than Odd" : even < odd ? "Odd is greater than Even" : "Even and Odd are the same";
        }

        /*
         Or just 
         return new[] {"Odd is greater than Even", "Even and Odd are the same", "Even is greater than Odd"}[
        str.Select(c => int.Parse(c.ToString())).Sum(i => i % 2 == 0 ? i : -i).CompareTo(0) + 1];
        */
    }
}
