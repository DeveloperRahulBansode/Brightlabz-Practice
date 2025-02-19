using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Calculator
    {

        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a,int b) 
        { 
            return a - b; 
        }

        public int Multiplication(int a,int b)
        {
            return a * b;
        }

        public int Division(int a,int b)
        {
            return a / b;
        }




        public  bool Checkstringpalindrome(string str)
        {
            var left = 0;
            var right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                    
                }
                left++;
                right--;
            }
            return true;


        }
    }

}
