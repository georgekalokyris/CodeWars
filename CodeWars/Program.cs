using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CodeWars
{
    class  Program
    {
        static void Main(string[] args)
        {
            var a = is_valid_IP("123.045.067.089");
            var b = is_valid_IP("");
            var c = is_valid_IP("0.0.0.0");
            var d = is_valid_IP("abc.def.ghi.jkl");
            var e = is_valid_IP("pr12.34.56.78");
            var f = is_valid_IP("96.198.184.");
            

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

        }

        public static bool is_valid_IP(string ipAddres)
        {
            if (ipAddres.Length == 0) return false;
            //if (ipAddres.Any(x => !char.IsNumber(x))) return false;

            var ip = ipAddres.Split('.');

            if (ip.Length < 4 || ip.Length >= 5) return false;

            foreach (var item in ip)
            {
                if (item.StartsWith("0") && item.Length > 1) return false;

                if (item.Any(x => !char.IsNumber(x))) return false;

                if (item.Contains(' ')|| item == "" || item.Any(x=> String.IsNullOrEmpty(x.ToString()))) return false;

                if (item.Any(x => char.IsNumber(x)))
                {
                    if (int.Parse(item) < 0 || int.Parse(item) > 255)
                    {
                        return false;
                    }
                } 
                   
                
            }

            return true;
        }

    }
}
