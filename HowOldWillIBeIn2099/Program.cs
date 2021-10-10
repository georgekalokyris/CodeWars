using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowOldWillIBeIn2099
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateAge(2003, 2020));
            Console.WriteLine(CalculateAge(2019, 2020));
            Console.WriteLine(CalculateAge(2003, 2003));
            Console.WriteLine(CalculateAge(2020, 2003));
            Console.WriteLine(CalculateAge(2020, 2019));

        }

        public static string CalculateAge(int birth, int yearTo)
        {
            int age = yearTo - birth;

            string OptionA = "You were born this very year!";
            string OptionB = $"You are 1 year old.";
            string OptionC = $"You are {age} years old.";
            string OptionD = $"You will be born in 1 year";
            string OptionE = $"You will be born in {Math.Abs(age)} years.";


            return birth == yearTo ? OptionA :
                   age == 1 ? OptionB :
                   age > 1 ? OptionC :
                   age == -1 ? OptionD : OptionE;
        }


    }
}
