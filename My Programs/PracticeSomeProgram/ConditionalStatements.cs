using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSomeProgram
{
    internal class ConditionalStatements
    {
        public static void IfStatement()
        {
            int x = 10;
            if (x > 5)
            {
                Console.WriteLine("x is greater than 5");
            }
        }

        public static void IfelseStatement() 
        {
            int a = 10;
            if (a > 15)
            {
                Console.WriteLine("a is greater than 15");
            }
            else
            {
                Console.WriteLine("a is less than 15");
            }


        }

        public static void IfelseIfStatement()
        {
            int b = 20;
            if (b == 10)
            {
                Console.WriteLine("b is 10");
            }
            else if (b == 20)
            {
                Console.WriteLine("b is 20");
            }
            else
            {
                Console.WriteLine("b is not 10 or 20");
            }
        }

        public static void NestedIfStatement()
        {
            int c = 100;
            if (c == 100)
            {
                if (c < 200)
                {
                    Console.WriteLine("c is less than 200");
                }
                else
                {
                    Console.WriteLine("c is greater than 200");
                }


            }
            else
            {
                Console.WriteLine("c is not 100");
            }
        }
        public static void SwitchCaseStatement()
        {
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;

            }
        }




        }
    }
