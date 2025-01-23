using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSomeProgram
{
    internal class CalculatelenghtofLine
    {

        public static void CalculateLength()
        {
            Console.WriteLine("Enter the value Of X1=");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value Of Y1=");
            double y1 = Convert.ToDouble(Console.ReadLine()); ;

            Console.WriteLine("Enter the value Of X2=");
            double x2 = Convert.ToDouble(Console.ReadLine()); ;

            Console.WriteLine("Enter the value Of X2=");
            double y2 = Convert.ToDouble(Console.ReadLine()); ;

            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Length of the line is = {length}");
        }



    }
}
