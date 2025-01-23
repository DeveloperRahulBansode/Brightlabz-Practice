
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSomeProgram
{
    internal class LoopingStatements
    {

        public static void ForLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }
        }

        public static void WhileLoop()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Value of i: {0}", i);
                i++;
            }
        }

        public static void DoWhileLoop()
        {
            int i = 0;
            do
            {
                Console.WriteLine("Value of i: {0}", i);
                i++;
            } while (i < 5);
        }

        public static void NestedLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("i: {0}, j: {1}", i, j);
                }
            }
        }

        
    }
}
