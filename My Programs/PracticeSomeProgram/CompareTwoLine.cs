using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSomeProgram
{
    internal class CompareTwoLine
    {

        public static void CompareTwoLines()
        {
            double x1 = 2.1;
            double y1 = 3.1;
            double x2 = 4.1;
            double y2 = 5.1;
            double x3 = 6.1;
            double y3 = 7.1;
            double x4 = 8.1;
            double y4 = 9.1;
            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            if (length1.CompareTo(length2) == 0)
            {
                Console.WriteLine("Length of the lines are equal");
            }
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("Length of the line1 is greater than line2");
            }
            else if (length1.CompareTo(length2) < 0)
            {
                Console.WriteLine("Length of the line1 is less than line2");
            }
            else
            {
                Console.WriteLine("Length of the lines are not equal");
            }

        }
    }
}
