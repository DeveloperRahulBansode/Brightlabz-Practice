using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndNon_GenericCollections
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public Employee(int EmployeeID,string EmployeeName,int EmployeeAge)
        {
            this.Id = EmployeeID;
            this.Name = EmployeeName;
            this.Age = EmployeeAge;


        }

       



        public override string ToString() {
            return "Employee [ ID :"+Id+", Name :"+Name+", Age : "+Age+" ]";
        
        }


    }
    public delegate void Calculate(int a,int b);
    public class Qustions
    {




        public static void equalString(string str1,string str2)
        {
            Func<string,string,bool> chekstring=(str1,str2)=>str1.Equals(str2);

            if (chekstring(str1, str2))
                Console.WriteLine("String are Equal");
            else
                Console.WriteLine("String are Not Equal");
            


        }

        public static void EvenOrOddNumber(int num)
        {
            Func<int, bool> evenODD = (num) => num % 2 == 0;

            if (evenODD(num))
                Console.WriteLine("Number Is Even");
            else
                Console.WriteLine("Number is ODD");
            
        }

        public static void stringPalyndrom(string str)
        {
            var left = 0;
            var right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    Console.WriteLine(str+" not Palyndrom");
                    break;
                }
                else
                {
                    Console.WriteLine(str+" is palyendrom");
                }
                left++;
                right--;




            }
          

        }
        public static void addData(int x,int y)
        {
            Console.WriteLine("Addition ="+(x+y));
            

        }
        public static void subData(int x, int y)
        {
            Console.WriteLine("Subtraction= "+(x-y));

        }
    }
}
