using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSomeProgram
{
    internal class ExceptionHandlingDemo
    {
        public int numerator; 
        public int denominator; 
        public int total;


        public void Calculation() {


            if (denominator != 0)
            {
                total = numerator / denominator;
                Console.WriteLine(total);

            }
            else {
                throw new DevideByZero();
            }





        }


    }
    //custome Exception class
    public class DevideByZero:Exception
    {
        public DevideByZero()
        {
            Console.WriteLine("This Is Costime DEvide By Zero Exception");
        }



    }
}
