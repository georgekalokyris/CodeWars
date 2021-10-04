using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/5a360620f28b82a711000047/train/csharp
namespace DefineACardSuit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DefineSuit("10♣"));
        }
        public static string DefineSuit(string card)
        {
            switch (card[card.Length-1])
            {
                case '♣':
                    return "clubs";
                case '♦':
                    return "diamonds";
                case '♥':
                    return "hearts";
                case '♠':
                    return "spades";
                default:
                    return "";
            }
        }
    }
}
