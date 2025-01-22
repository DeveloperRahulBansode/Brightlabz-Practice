using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class reverceString
    {

        public static void revString()
        {
            Console.WriteLine("Enter Your String For Reverce");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();

            String reverce = "";
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                reverce += ch[i];
            }

            Console.WriteLine(reverce);
        }

    }
}
