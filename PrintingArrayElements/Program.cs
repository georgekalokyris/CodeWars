using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/56e2f59fb2ed128081001328/train/csharp
namespace PrintingArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new object[] { 2.1, 4, 5, 2 };
            Console.WriteLine(PrintArray(data));

            var data2 = new object[] { "hello", "this", "is", "a", "test" };
            var data3 = new object[] { "Test", "a", "b" };
            var data4 = new object[] { data2, data3 };
            Console.WriteLine(PrintArray(data4));
        }

        public static string PrintArray(object[] array)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var x in array)
            {
                if(x.GetType() == typeof(object[]))
                {
                    foreach(var y in (object[])x)
                    {
                        sb.Append(y+",");
                    }
                }
                else
                {
                    sb.Append(x+",");
                }

            }

            return sb.ToString().Substring(0, sb.Length - 1);
;        }
    }
}
