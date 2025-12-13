using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    public abstract class Geometry
    {
        public abstract double Area();
    }

    public class Rectangle : Geometry
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area() { return Width * Height; }
    }

    public class Circle : Geometry
    {
        private double Radius { get; set; }
        private const double PI = 3.14159;

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area() { return Math.Pow(Radius, 2) * PI; }
    }

    public class Triangle : Geometry
    {
        private double Leg1 { get; set; }
        private double Leg2 { get; set; }

        public Triangle(double leg1, double leg2)
        {
            Leg1 = leg1;
            Leg2 = leg2;
        }
        public override double Area()
        {
            return Leg1 * Leg2 * 0.5;
        }
    }

    public class Trapezoid : Geometry
    {
        private double Base1 { get; set; }
        private double Base2 { get; set; }
        private double Height { get; set; }

        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }
        public override double Area()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }
    }
}
