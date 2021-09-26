using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acrostic_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReadOut(new string[] { "Jolly", "Amazing", "Courteous", "Keen" }));
            Console.WriteLine(ReadOut(new string[] { "Marvelous", "Excellent", "Gifted" }));
        }

        public static string ReadOut(string[] acrostic) => new string(acrostic.Select(x => x[0]).ToArray());
    }
}
