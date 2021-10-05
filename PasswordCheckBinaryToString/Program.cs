using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheckBinaryToString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DecodePass(new string[] { "password123", "admin", "admin1" }, "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011"));
        }

        public static string DecodePass(string[] passArr, string bin)
        {
            var binarySplitted = bin.Split(' ');
            var byteList = new List<char>();

            foreach (var item in binarySplitted)
            {
                char pass = (char)BinaryToDecimal(item);
                byteList.Add(pass);
            }

            var final = string.Join("", byteList.ToArray());

            return passArr.Contains(final) ? final : null;
        }

        public static decimal BinaryToDecimal(string x)
        {
            return Convert.ToInt32(x,2);
        }
        
    }
}
