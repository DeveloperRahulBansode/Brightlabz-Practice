using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class OddAndEven
    {
        public static void oddEvenFind()
        {
            Console.WriteLine("Enter The Number To Find Odd Even=");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number Is Even");
            }
            else
            {
                Console.WriteLine("Number Is Odd");
            }





        }



    }
}
