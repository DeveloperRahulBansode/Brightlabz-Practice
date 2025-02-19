using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConcept
{
    public delegate void Arithmatic(int a, int b);
    public delegate T arithmatic<T>(T a,T b);
    public class DelegatesDemo
    {
        public static void Addition(int a, int b) 
        {
            Console.WriteLine(a+b);
        }

        public static void multiplication(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        public static void div(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        public static int add(int a,int b)
        {
            return a + b;
        }
        public static float Sub(float a, float b)
        {
            return a - b;
        }


        public static float Div(int a, float b)
        {
            return a / b;
        }

       




    }
}
