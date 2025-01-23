using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSomeProgram
{
    internal class BranchingStatement
    {
        public static void BreakStatement()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine("Value of i: {0}", i);
            }
        }

        public static void ContinueStatement()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine("Value of i: {0}", i);
            }
        }

    }
    
    
}
