using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class ArmstrongNumber
    {
        public static void checkArmstrong()
        {
            Console.WriteLine();
            Console.WriteLine("Enter Your Number For Armstrong=");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;
            int n = num.ToString().Length;
            while (num != 0)
            {
                int remainder = num % 10;

                sum = sum + (int)Math.Pow(remainder, n);
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine(temp + " Number is Armstrong");
            }
            else { Console.WriteLine(temp + " Number is Not Armstrong"); }
        }

    }
}
