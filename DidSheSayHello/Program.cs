using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/56a4addbfd4a55694100001f/train/csharp

namespace DidSheSayHello
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------");
            Console.WriteLine(Validate_hello("hello"));
            Console.WriteLine(Validate_hello("ciao bella!"));
            Console.WriteLine(Validate_hello("salut"));
            Console.WriteLine(Validate_hello("hallo, salut"));
            Console.WriteLine(Validate_hello("hombre! Hola!"));
            Console.WriteLine(Validate_hello("Hallo, wie geht\'s dir?"));
            Console.WriteLine(Validate_hello("AHOJ!"));
            Console.WriteLine(Validate_hello("czesc"));
            Console.WriteLine(Validate_hello("Ahoj"));
            Console.WriteLine(Validate_hello("meh"));

        }

        public static bool Validate_hello(string greetings)
        {
            string[] langs = new string[7] {"hello",
                                            "ciao" ,
                                            "salut",
                                            "hallo",
                                            "hola" ,
                                            "ahoj" ,
                                            "czesc"};

            return langs.Any(x => greetings.ToUpper().Contains(x.ToUpper()));
        }
    }
}
