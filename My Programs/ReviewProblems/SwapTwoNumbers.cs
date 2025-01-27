using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    internal class SwapTwoNumbers
    {
        public static void SwapWithouteVariable(int a,int b)
        {

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping: " + a + " " + b);
        }   


    }
}
