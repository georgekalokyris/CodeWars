using System;
using System.Linq;

namespace CanalManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(CanalMania(new uint[] { 2, 3, 6, 1 }, new uint[] { 1, 2 }, 7)); //38
            Console.WriteLine(CanalMania(new uint[] { 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, new uint[] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 30)); //868
            Console.WriteLine(CanalMania(new uint[] { 4, 1, 8, 2, 6 }, new uint[0], 8)); //54
            Console.WriteLine(CanalMania(new uint[0], new uint[] { 4, 4, 7, 2, 8, 5 }, 8)); //80
            Console.WriteLine(CanalMania(new uint[0], new uint[0], 10)); //0

        }


        public static uint CanalMania(uint[] lowQueue, uint[] highQueue, uint lockLength)
        {
            uint totalTime = 0;

            uint currentCapacity = lockLength;
            int totalBoats = lowQueue.Count() + highQueue.Count();

            int j = 0; //Boat of the lowQueue
            int k = 0; //Boat of the highQueue
            bool takeLow = true;

            while (totalBoats > 0) //Just to make sure all of the boats will pass
            {
                //Steps taken:
                //Step 1: Take 1 or more from the low until it fills up (Boat A + B + C <= length)
                //Step 2: Add the length boat * 2 of each boat
                //Step 3: Add + 2 seconds to the total 
                //Step 4: Regenerate the capacity
                //Step 5: Ensure the next pick will be from the other queue


                if (takeLow)
                {
                    for (; currentCapacity <= lockLength && j < lowQueue.Length; j++)
                    {
                        if (lowQueue[j] <= currentCapacity)
                        {
                            currentCapacity -= lowQueue[j];
                            totalTime += lowQueue[j] * 2;
                            totalBoats--;
                        }
                        else
                        {
                            break;
                        }
                    }
                    totalTime += 2;
                    takeLow = false;
                    currentCapacity = lockLength;

                    Console.WriteLine($"Done with lowQueue, total time: {totalTime}");
                }
                else
                {
                    for (; currentCapacity <= lockLength && k < highQueue.Length; k++)
                    {
                        if (highQueue[k] <= currentCapacity)
                        {
                            currentCapacity -= highQueue[k];
                            totalTime += highQueue[k] * 2;
                            totalBoats--;
                        }
                        else
                        {
                            break;
                        }
                    }
                    totalTime += 2;
                    takeLow = true;
                    currentCapacity = lockLength;

                    Console.WriteLine($"Done with highQueue, total time: {totalTime}");

                }


            }

            if (takeLow == false) totalTime += 2; 

            return totalTime;
        }
    }
}
