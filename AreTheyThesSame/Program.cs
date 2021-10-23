using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreTheyThesSame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };

            bool r = comp(a, b);
            Console.WriteLine(r);

            int[] c = new int[] { 2, 2, 3 };
            int[] d = new int[] { 4, 9, 9 };

            Console.WriteLine(comp(c,d));
        }
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null) return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (!b.Any(x => x == Math.Pow(a[i], 2))) return false;

                int bNum = b.FirstOrDefault(x => x == Math.Pow(a[i], 2));
                int bIndex = Array.IndexOf(b,bNum);
                b[bIndex] = 0;
            }

            if (b.Any(x => x > 0)) return false;

            return true;
        }

        /* or just
         
              public static bool comp(int[] a, int[] b)
              {
                if ((a == null) || (b == null)){
                  return false;
                }

                int[] copy = a.Select(x => x * x).ToArray();
                Array.Sort(copy);
                Array.Sort(b);

                return copy.SequenceEqual(b);
              }
        */


    }
}
