using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codewars.com/kata/5e2596a9ad937f002e510435/train/csharp

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(infected("00001X11111"));
            Console.WriteLine(infected("01000000X000X011X0X"));
            Console.WriteLine(infected("01X000X010X011XX"));
            Console.WriteLine(infected("XXXXX"));
            Console.WriteLine(infected("0000000010"));
            Console.WriteLine(infected("X00X000000X10X0100"));

        }

        public static double infected(string s)
        {
            //Create an array of strings split by 'X' and calculate the 
            string[] Continents = s.Split('X');

            //Infected Game Start
            int IFstart = 0;

            //Uninfected Game Start
            int UFstart = 0;

            //Infected Game End;
            int IFend = 0;

            //Uninfected Game End
            int UFend = 0;

            foreach (string continent in Continents)
            {
                //Not X
                if(continent.Contains("0") || continent.Contains("1"))
                {
                    int ContinentInfected = continent.Where(x => (x == '1')).Count();
                    
                    int ContinentUninfected = continent.Where(x => (x == '0')).Count();
                   
                    IFstart += ContinentInfected;
                    UFstart += ContinentUninfected;

                    //If there is at least one infected
                    if(ContinentInfected > 0)
                    {
                        IFend += ContinentUninfected + ContinentInfected;
                    }
                    else if(ContinentUninfected > 0)
                    {
                        UFend += ContinentUninfected; //Not used really anywhere
                    }
                }
            }
            
            if(IFstart > 0 || UFstart > 0)
            {
                return 100 * IFend / Convert.ToDouble((IFstart + UFstart));
            }
            else
            {
                return 0;
            }
        }
    }
    
  
}
