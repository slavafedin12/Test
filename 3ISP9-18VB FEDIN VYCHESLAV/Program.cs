using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyMath;
namespace _3ISP9_18VB_FEDIN_VYCHESLAV
{
    public class Program
    {
        static void Main(string[] args)
        {
            AlgebraA();
            TrigonometryT();
            GeometryG();

            Console.ReadKey();
        }

        public static void AlgebraA()
        {
            Console.WriteLine("Корень квадратного уравнения: " + Algebra.SquareEquation(4, 6, 7));
            Console.WriteLine("Корень линейного уравнения: " + Algebra.SolveLinearEquation(0, 7));
            double result = Algebra.SeriesSum(6, 8, 9, 11, 14);
            Console.WriteLine("Сумма ряда: " + result);
            double results = Algebra.MaxSeriesSum(10, 12, 43, 84, 35);
            Console.WriteLine("Максимальное значение из ряда: " + results);
            double res = Algebra.AverageSeriesSum(6, 2, 9, 4, 14);
            Console.WriteLine("Среднее значение из ряда: " + res);
        }

        public static void TrigonometryT()
        {
            Console.WriteLine("Sin x: " + Trigonometry.Sin(90));
            Console.WriteLine("Cos x: " + Trigonometry.Cos(60));
            Console.WriteLine("tg x: " + Trigonometry.Tg(45));
            Console.WriteLine("Ctg x: " + Trigonometry.Ctg(90));
            Console.WriteLine("Arcsin x: " + Trigonometry.Arcsin(0));
        }
        
        public static void GeometryG()
        {
            Console.WriteLine("Площадь треугольника: " + Geometry.Triangle(10, 20, 10));
            Console.WriteLine("Площадь прямоугольного треугольника: " + Geometry.RightTriangle(15, 2));
            Console.WriteLine("Площадь прямоугольника: " + Geometry.Rectangle(45, 8));
            Console.WriteLine("Площадь круга: " + Geometry.Circle(3));
            Console.WriteLine("Площадь трапеции: " + Geometry.Trapeze(13, 7, 5));
        }
    }
    }

