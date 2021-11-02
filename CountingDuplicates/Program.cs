using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DuplicateCount("abcde"));
            Console.WriteLine(DuplicateCount("aabbcde"));
            Console.WriteLine(DuplicateCount("aabBcde"));
        }

        public static int DuplicateCount(string str)
        {

            var result = str.GroupBy(x => char.ToUpper(x)).Where(y=>y.Count() > 1).Select(c=>c.Key);

            return result.Count();

        }
    }
}
