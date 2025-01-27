using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    internal class TypeConversion
    {

        public static void TypeConversionOfData() {

            //Explicit Conversion Double To Int
            double a = 12.5;
            
            int b = (int)a;

            Console.WriteLine("Explicit Convert Double To Int=" + b);

            //implicit Conversion Int To Double
            int c = 12;
            double d = c;
            Console.WriteLine("implicit Convert Int To Double=" + d);


            //Explicit Conversion String To Int
            string e = "123";
            int f = Convert.ToInt32(e);

            Console.WriteLine("Explicit Convert String To Int=" + f);

            //Implicit Conversion Int To String
            int g = 123;
            string h = g.ToString();

            Console.WriteLine("Implicit Convert Int To String=" + h);

        }

    }
}
