using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    internal class GenericMaxValue
    {

        public static void FindMaxValueInArray<T>(T[] array) where T : IComparable
        {
            if (array == null)
            {
                Console.WriteLine("Array is empty");
            }
            var Max = array[0];

            foreach (var data in array)
            {
                if (Max.CompareTo(data) < 0)
                {
                    Max = data;

                }
             }
            Console.WriteLine("The Maximum Value In Array is ="+Max);

        }




    }
}
