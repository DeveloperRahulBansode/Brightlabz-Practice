using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public class Shape
    {

       public virtual void DisplayInfo()
        {
            Console.WriteLine("This is Shape class Shape");
        }

    }
    public class Circle : Shape
    {
        private double radius;

        public Circle() { }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void DisplayInfo()
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine(" Circle Area=" + area);
        }



       

    }

    public class Rectangle : Shape
    {
        private double length;
        private double breadth;
        public Rectangle() { }
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void DisplayInfo()
        {
            double area = length * breadth;
            Console.WriteLine(" Rectangle Area=" + area);
        }
    }
    public class Triangle : Shape
    {
        private double basee;
        private double height;
        public Triangle() { }
        public Triangle(double basee, double height)
        {
            this.basee = basee;
            this.height = height;
        }
        public override void DisplayInfo()
        {
            double area = 0.5 * basee * height;
            Console.WriteLine(" Triangle Area=" + area);
        }
    }
}
