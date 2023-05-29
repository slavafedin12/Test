using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyMath;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        //геометрия


        [TestMethod]
        public void TestMethodGeomTriangle102010()
        {
            double a = 10;
            double b = 20;
            double c = 10;

            var res = MyMath.Geometry.Triangle(a, b, c);
            double otvet1 = 20;
            double otvet2 = 0;

            Assert.AreEqual(otvet2, res, otvet1);
        }

        [TestMethod]
        public void TestMethodGeomRTriangle152()
        {
            double a = 15;
            double b = 2;

            var res = MyMath.Geometry.RightTriangle(a, b);
            double otvet1 = 15;
            double otvet2 = 0;

            Assert.AreEqual(otvet2, res, otvet1);
        }
        
        [TestMethod]
        public void TestMethodGeomRectangle458()
        {
            double a = 45;
            double b = 8;

            var res = MyMath.Geometry.Rectangle(a, b);
            double otvet1 = 360;
            double otvet2 = 0;

            Assert.AreEqual(otvet2, res, otvet1);
        }
        
        [TestMethod]
        public void TestMethodGeomCircle3()
        {
            double r = 3;

            var res = MyMath.Geometry.Circle(r);
            double otvet1 = 28.26;
            double otvet2 = 0;

            Assert.AreEqual(otvet2, res, otvet1);
        }
        
        [TestMethod]
        public void TestMethodGeomTrapeze1375()
        {
            double a = 13;
            double b = 7;
            double h = 5;

            var res = MyMath.Geometry.Trapeze(a,b,h);
            double otvet1 = 8;
            double otvet2 = 0;

            Assert.AreEqual(otvet2, res, otvet1);
        }


        //тригонометрия


        [TestMethod]
        public void TestMethodTrigonomSin90()
        {
            double x = 90;
      
            var res = MyMath.Trigonometry.Sin(x);
            double otvet1 = 1;
            double otvet2 = 0;

            Assert.AreEqual(otvet2, res, otvet1);
        }

        [TestMethod]
        public void TestMethodTrigonomCos60()
        {
            double x = 0;

            var res = MyMath.Trigonometry.Cos(x);
            double otvet1 = 1/2;
            double otvet2 = 1;

            Assert.AreEqual(otvet2, res, otvet1);
        }

        [TestMethod]
        public void TestMethodTrigonomTg45()
        {
            double y = 45;

            var res = MyMath.Trigonometry.Tg(y);
            double otvet1 = 1;
            double otvet2 = 1;

            Assert.AreEqual(otvet2, res, otvet1);
        }
        
        [TestMethod]
        public void TestMethodTrigonomCtg45()
        {
            double y = 45;

            var res = MyMath.Trigonometry.Ctg(y);
            double otvet1 = 1;
            double otvet2 = -0;

            Assert.AreEqual(otvet2, res, otvet1);
        }
        
        [TestMethod]
        public void TestMethodTrigonomArcsin0()
        {
            double y = 0;

            var res = MyMath.Trigonometry.Arcsin(y);
            double otvet1 = 0;
            double otvet2 = -0;

            Assert.AreEqual(otvet2, res, otvet1);
        }

        //алгебра


        [TestMethod]
        public void TestMethodAlgebraSE467()
        {
            double a = 4;
            double b = 6;
            double c = 7;

            var res = MyMath.Algebra.SquareEquation(a,b,c);
            

            Assert.AreEqual(res, null);
        }

        [TestMethod]
        public void TestMethodAlgebraSLE34()
        {
            double a = 0;
            double b = 7;

            var res = MyMath.Algebra.SolveLinearEquation(a,b);
            

            Assert.AreEqual(double.NaN, res);
        }

        [TestMethod]
        public void TestMethodAlgebraSS()
        {
            double a = 6;
            double b = 8;
            double c = 9;
            double d = 11;
            double e = 14;

            var res = MyMath.Algebra.SeriesSum(a, b, c, d, e);


            Assert.AreEqual(48, res);
        }

        [TestMethod]
        public void TestMethodAlgebraMSS()
        {
            double a = 10;
            double b = 12;
            double c = 43;
            double d = 84;
            double e = 35;

            var res = MyMath.Algebra.MaxSeriesSum(a, b, c, d, e);


            Assert.AreEqual(84, res);
        }

        [TestMethod]
        public void TestMethodAlgebraASS()
        {
            double a = 6;
            double b = 2;
            double c = 9;
            double d = 4;
            double e = 14;

            var res = MyMath.Algebra.AverageSeriesSum(a, b, c, d, e);


            Assert.AreEqual(7, res);
        }
    }
}
