using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGeneric
{
    internal class StackDemo
    {
    
        public static void stackdemo()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Pop();
            int pop = stack.Pop();
            Console.WriteLine(pop);


            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
