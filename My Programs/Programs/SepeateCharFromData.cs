using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class SepeateCharFromData
    {
        public static void printChar()
        {
            Console.WriteLine();
            Console.WriteLine("Enter The String=");
            String data = Console.ReadLine();
            char[] ch = data.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= '0' && ch[i] <= '9')
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(data[i]);
                }
            }

        }
    }
}
