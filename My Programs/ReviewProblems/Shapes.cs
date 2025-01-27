using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public abstract class Shapes
    {

        public abstract void CalculateArea();

       public void DisplayInfo()
        {
            Console.WriteLine("Displaying Shapes");
        }


    }
    public class Circlee : Shapes
    {
        private double radius;
        public Circlee() { }
        public Circlee(double radius)
        {
            this.radius = radius;
        }
        public override void CalculateArea()
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine("Displaying Circle Area=" + area);
        }
    }





}
