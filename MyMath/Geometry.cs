using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Geometry
    {
        //площадь треугольника

        public static double Triangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

        //площадь прямоугольного треугольника

        public static double RightTriangle(double a, double b)
        {
            return (a * b) / 2;
        }

        //площадь прямоугольника

        public static double Rectangle(double a, double b)
        {
            return a * b;
        }

        //площадь круга

        public static double Circle(double r)
        {
            return 3.14 * (r * r);
        }


        //площадь трапеции

        public static double Trapeze(double a, double b, double h)
        {
            return (a + b) / h * 2;
        }
    }
}