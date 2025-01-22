using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class PalendromNumber
    {
        public static void checkPalendrom()
        {
            Console.WriteLine();
            Console.WriteLine("Enter Your Number For Palendrom=");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int reverse = 0;
            while (num != 0)
            {
                int remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
            }
            if (temp == reverse)
            {
                Console.WriteLine(temp + " Number is Palendrom");
            }
            else { Console.WriteLine(temp + " Number is Not Palendrom"); }
        }
    }
}
