using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class PerfectNumber
    {
        public static void perfectNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Enter Your Number For Perfect Number=");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == temp)
            {
                Console.WriteLine(temp + " Number is Perfect Number");
            }
            else { Console.WriteLine(temp + " Number is Not Perfect Number"); }




        }



    }
}
