using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_17_OOP
{
    abstract class Triangle
    {
        protected double side1;
        protected double side2;
        protected double angle;

        public Triangle(double s1, double s2, double a)
        {
            side1 = s1;
            side2 = s2;
            angle = a*Math.PI/180;
        }

        public abstract double Area();
        public abstract double Perimeter();
    }

    class RightTriangle : Triangle
    {
        public RightTriangle(double s1, double s2) : base(s1, s2, 90) { }

        public override double Area()
        {
            return side1 * side2 / 2;
        }

        public override double Perimeter()
        {
            return side1 + side2 + Math.Sqrt(side1 * side1 + side2 * side2);
        }
    }

    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double s, double a) : base(s, s, a) { }

        public override double Area()
        {
            return side1 * side1 * Math.Sin(angle) / 2;
        }

        public override double Perimeter()
        {
            return 2 * side1 + side2;
        }
    }

    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double s) : base(s, s, 60) { }

        public override double Area()
        {
            return side1 * side1 * Math.Sqrt(3) / 4;
        }

        public override double Perimeter()
        {
            return 3 * side1;
        }
    }
}
