using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Trigonometry
    {

        //синус 

        public static double Sin(double x)
        {
            return Math.Sin(x);
        }


        //косинус

        public static double Cos(double x)
        {
            return Math.Cos(x);
        }


        //тангенс

        public static double Tg(double y)
        {
            return Math.Tan(y);
        }


        //котангенс

        public static double Ctg(double y)
        {
            return 1 / Math.Tan(y);
        }


        //арксинус

        public static double Arcsin(double y)
        {
            return Math.Asin(y);

        }
    }
}
    

