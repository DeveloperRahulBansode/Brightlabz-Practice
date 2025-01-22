using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class SplitAndJoin
    {
        public static void splitAndJoin()
        {
            Console.WriteLine();
            Console.WriteLine("Enter The String=");
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            string strJoin = string.Join(",", strArray);
            Console.WriteLine(strJoin);
        }
    }
}
