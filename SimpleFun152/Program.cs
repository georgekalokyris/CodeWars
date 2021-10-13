using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.codewars.com/kata/58acfe4ae0201e1708000075/train/csharp
namespace SimpleFun152
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InviteMoreWomen(new int[]{1,-1,1}));
            Console.WriteLine(InviteMoreWomen(new int[]{1,1,1}));
            Console.WriteLine(InviteMoreWomen(new int[]{-1,-1,-1}));
            Console.WriteLine(InviteMoreWomen(new int[]{1,-1}));
        }

        public static bool InviteMoreWomen(int[] L)
        {
            int women = L.Where(x => x == -1).Count();
            int men = L.Where(x => x == 1).Count();
            return men > women ? true : false;
        }
    }
}
