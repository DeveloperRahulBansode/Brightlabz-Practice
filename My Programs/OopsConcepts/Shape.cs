using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class Shape
    {
        public virtual void GetArea()
        {
            Console.WriteLine("Area Of Shapes");
        }
    }


    public class Circle : Shape
    {
        public Circle() { }

        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override void GetArea()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of Circle=" + area);
        }
    }

    public class Rectangle : Shape
    {

        private double lenght;
        private double breadth;
        public Rectangle() { }

        public Rectangle(double lenght, double breadth)
        {

            this.lenght = lenght;
            this.breadth = breadth;
        }

        public override void GetArea()
        {
            double area=lenght*breadth;
            Console.WriteLine("Area Of Rectangle="+area);

        }

    }
}
