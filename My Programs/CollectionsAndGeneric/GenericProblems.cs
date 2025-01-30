using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGeneric
{
    internal class GenericProblems
    {

        public static void FindMax<T>(T data1, T data2, T data3) where T : IComparable<T>
        {

            
            if (data1.CompareTo(data2)>0 && data1.CompareTo( data3)>0)
            {
                Console.WriteLine("data1="+data1+" is Max");
            }
            else if (data2.CompareTo(data1)>0 && data2.CompareTo(data3)>0)
            {
                Console.WriteLine("data2="+data2+" is Max");
            }
            else
            {
                Console.WriteLine("data3="+data3+" is Max");

            }
        }
        public static void swapTwoNumbers<T>(T data1, T data2) where T : INumber<T>
        {

            
            //T temp;
            //temp = data1;
            //data1 = data2;
            //data2 = temp;
            data1 = data1 + data2;
            data2 = data1 - data2;
            data1 = data1 - data2;
            Console.Write(data1 + " " + data2);
        }



    }
}
