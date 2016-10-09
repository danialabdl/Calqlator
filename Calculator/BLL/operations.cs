using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class operations
    {

        public static string num { get; set;}
        public static string numKeeper { get; set; }
        public static double product { get; set; }

        public static string selector { get; set;}
        
       



        public operations()
        {
            num= "";
            numKeeper = "";
            selector = "";
            
        }


        public static double add(string a,string b)
        {
            product = Convert.ToDouble(numKeeper) + Convert.ToDouble(num);
            return product;
        }
        public static double sub(string a, string b)
        {
            product = Convert.ToDouble(numKeeper) - Convert.ToDouble(num);
            return product;
        }
        public static double mul(string a, string b)
        {
            product = Convert.ToDouble(numKeeper) * Convert.ToDouble(num);
            return product;
        }
        public static double div(string a, string b)
        {
            product = Convert.ToDouble(numKeeper) / Convert.ToDouble(num);
            return product;
        }
    }
}
