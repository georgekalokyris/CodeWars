using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/5848565e273af816fb000449/train/csharp
namespace Encrypt_This_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EncryptThis(""));
            Console.WriteLine(EncryptThis("A"));
            Console.WriteLine(EncryptThis("Ab"));
            Console.WriteLine(EncryptThis("Abc"));
            Console.WriteLine(EncryptThis("Abcd"));
            Console.WriteLine(EncryptThis("A wise old owl lived in an oak"));
            Console.WriteLine(EncryptThis("The more he saw the less he spoke"));
            Console.WriteLine(EncryptThis("The less he spoke the more he heard"));
            Console.WriteLine(EncryptThis("Why can we not all be like that wise old bird"));
            Console.WriteLine(EncryptThis("Thank you Piotr for all your help"));
        }

        private static string EncryptThis(string v1)
        {
            if (v1 == "") return "";

            string[] Words = v1.Split(' ');

            string final = "";

            foreach (var word in Words)
            {
                if (word.Length == 1)
                {
                    final += Convert.ToInt32(char.Parse(word)) + " ";
                }
                else if(word.Length == 2)
                {
                    final += Convert.ToInt32(word[0]) + word[1].ToString() + " ";
                }
                else if(word.Length == 3)
                {
                    char second = word[1];
                    char last = word[word.Length - 1];
                    final += (int)word[0] +
                            last.ToString() +
                            second.ToString() +
                            " ";
                }
                else
                {
                char second = word[1];
                char last = word[word.Length - 1];
                final += (int)word[0] +
                        last.ToString() +
                        word.Substring(2, word.Length - 3) +
                        second.ToString() +
                        " ";
                }
             
            }

            return final.TrimEnd(' ');   
        }


        /* Best practice solution
          public static string EncryptThis(string s)
          => string.Join(" ", s.Split(' ').Select(Encrypt));
        
        private static string Encrypt(string s)
        {
          if(string.IsNullOrEmpty(s)) return "";
          else if(s.Length == 1) return $"{(int)s[0]}";
          else if(s.Length == 2) return $"{(int)s[0]}{s[1]}";
          return $"{(int)s[0]}{s.Last()}{s.Substring(2, s.Length-3)}{s[1]}";
        }
        */
    }
}
