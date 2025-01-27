using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    internal class FibonacciSeries
    {
        
        public static void Display(int n)
        {

            int first = 0;
            int second = 1;
            int next;
            int count = 2;

            Console.Write("Fibonacci Series= " + first + " " + second+" ");


            while (count < n)
            {
                next = first + second;
                Console.Write(+next+" ");
                first = second;
                second = next;
                count++;


            }






        }
    }
}
