using System;
using System.Linq;
using System.Collections.Generic;

namespace NotVerySecureKata
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Alphanumeric("Mazinkaiser"));
            Console.WriteLine(Alphanumeric("hello world_"));
            Console.WriteLine(Alphanumeric("PassW0rd"));
            Console.WriteLine(Alphanumeric("     "));
            Console.WriteLine(char.IsControl('&'));
            Console.WriteLine(char.IsSymbol('('));
            Console.WriteLine(char.IsSymbol(')'));
            Console.WriteLine("Should be false:" + Alphanumeric("\n\t\n"));
            Console.WriteLine("Should be false:" + Alphanumeric("&)))((("));


        }

        public static bool Alphanumeric(string str)
        {
            if (str == "") return false;

            string final = string.Concat(str.Where(x => !char.IsLetterOrDigit(x)));

            final += string.Concat(final.Where(x=> char.IsNumber(x)).Where(x => int.Parse(x.ToString()) > 9 || int.Parse(x.ToString()) < 0));

            return String.IsNullOrEmpty(final) ? true : false;
        }
    }
}
