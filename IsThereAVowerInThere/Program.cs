using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThereAVowerInThere
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = IsVow(new object[] { 118, "u", 120, 121, "u", 98, 122, "a", 120, 106, 104, 116, 113, 114, 113, 120, 106 });
            //new object[] { "e", 121, 110, 113, 113, 103, 121, 121, "e", 107, 103 }, Kata.IsVow(new object[] { 101, 121, 110, 113, 113, 103, 121, 121, 101, 107, 103 }));
            Console.WriteLine(x[1]);
            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}
        }

        public static object[] IsVow(object[] a)
        {
            char[] vowels = new char[]{'a','e','i','o','u'};
            for (int i = 0; i < a.Length; i++)
            {
                char c = Convert.ToChar(a[i]);
                if (vowels.Contains(c))
                {
                    a[i] = c.ToString();
                }
                else continue;
            }

            return a;
        }
    }
}
