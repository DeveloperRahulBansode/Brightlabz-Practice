using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    internal class MultiplicationTable
    {

        public static void multiplicationOfTable(int number)
        {


            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine(number + " * " + i + " = " + result);
            }
        }

    }
}
