using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class ReverceNumber
    {
        public static void reverceNumber()
        {
            Console.WriteLine("Enter Your Number For Reverce");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                Console.Write(num % 10);
                num = num / 10;



            }


        }
    }
}
