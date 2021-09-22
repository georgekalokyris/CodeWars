using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(AlphabetWar("zdqmwpbs"));

            //Console.WriteLine(AlphabetWar("z"));

            //Console.WriteLine(AlphabetWar("zdqmwpbs"));

            string s1 = "wwwwwwz";
            Console.WriteLine(AlphabetWar(s1));
        }





        public static string AlphabetWar(string fight)
        {
            char[] letters = fight.ToCharArray();

            char[] left = letters.Where(x => x == 'w' || x == 'p' || x == 'b' || x == 's').ToArray();

            char[] right = letters.Where(x => x == 'm' || x == 'q' || x == 'd' || x == 'z').ToArray();

            int leftScore = 0;
            int rightScore = 0;

            if (left.Length > 0)
            {
                foreach (var item in left)
                {
                    leftScore += item == 'w' ? 4 : item == 'p' ? 3 : item == 'b' ? 2 : item == 's' ? 1 : 0 ;
                }
            }

            if (right.Length > 0)
            {
                foreach (var item in right)
                {
                    rightScore += item == 'm' ? 4 : item == 'q' ? 3 : item == 'd' ? 2 : item == 'z' ? 1 : 0;
                }
            }

            return leftScore < rightScore ? "Right side wins!" : leftScore == rightScore ? "Let's fight again!":"Left side wins!" ;



        }
    }



}

