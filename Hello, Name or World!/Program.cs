using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codewars.com/kata/57e3f79c9cb119374600046b/train/csharp

namespace Hello__Name_or_World_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Hello("jEFF"));
            Console.WriteLine(Hello(""));
            Console.WriteLine(Hello());
        }

        public static string Hello(string name = "") => String.IsNullOrEmpty(name) ? "Hello, World!" : $"Hello, {name.Substring(0,1).ToUpper()}{name.Substring(1).ToLower()}!";
        
    }
}
