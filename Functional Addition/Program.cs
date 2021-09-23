using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Add(1)(3));
        }

        
        public static Func<double, double> Add(double n)
        {
            return x => x + n;
        }

    }
}
