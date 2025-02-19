using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConcept
{
    public  class ClosuresDemo
    {


        public Func<int> CreateCounter()
        {
            int counter = 0;
            return () => ++counter;
        }

        public static void ActionProceed() 
        {

            List<Action> list = new List<Action>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(() => Console.WriteLine(i));

            }
            foreach (Action action in list)
            {
                action();
            }
                      
        
        
        
        }

        public static void program()
        {
            int outerVariable = 10; // Captured variable

            void PrintMessage()
            {
                Console.WriteLine($"Captured Variable: {outerVariable}");
            }

            PrintMessage(); // Output: Captured Variable: 10

            outerVariable = 20;
            PrintMessage();
        }


    }
}
