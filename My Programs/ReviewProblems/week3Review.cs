using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public class week3Review
    {

        public static void EmailValidate(string email)
        {

            string pattern = @"^[a-z]+@[a-z]+\.[a-z]+";
            Regex regax=new Regex(pattern);

            if (regax.IsMatch(email)) {

                Console.WriteLine(email+"  is Valid ");
            
            }
            else
            {

                Console.WriteLine(email+"  is Invalid");
            }
           



        }
        public static void PasswordStrengthchecker(string password)
        {

            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[?&$#!\@]).{8}";
            Regex regax=new Regex(pattern);

            if (regax.IsMatch(password))
            {
                Console.WriteLine(password+" Good its Strong Password...");
            }
            else
            {
                Console.WriteLine(password+" No its Weak Password..");

            }
        
        
        }
        public static void PhoneNumberValidate(string contact)
        {

            string pattern = @"[0-9]{3}-[0-9]{3}-[0-9]{4}";
            Regex regax=new Regex(pattern);

            if (regax.IsMatch(contact)) {

                Console.WriteLine(contact+" Its Valid Contact Number");
            
            }
            else
            {
                Console.WriteLine(contact+" Its Invalid Contact Number");
            }

        }


        public static void DivisionException(int numer,int dino)
        {
            if (numer >= 0)
            {

                if (dino != 0)
                {
                    var result = numer / dino;
                    Console.WriteLine("Devision is =" + result);

                }
                else
                {
                    throw new DevideByZero();

                }
            }
            else
            {
                throw new InvalidInputFormat();

            }


        }

        public static void AgeException(int age)
        {
            if(age> 0 && age <150)
            {
                Console.WriteLine(age+" is valid age");
            }
            else
            {
                throw new ageValidator();

            }

        }
        public static void Bank(double withdrowal)
        {
            double balance = 50000;
            if (balance>withdrowal)
            {
                balance = balance - withdrowal;
                Console.WriteLine("Remaining Balence is= "+balance);


            }
            else
            {
                throw new InsufficientFundsException();
            }



        }
        public static void E_commerce(int stockEntry)
        {


            if (stockEntry !=0)
            {
                Console.WriteLine("Stock Updated...");

            }
            else
            {
                throw new ProductOutOfStockException();
            }
            


        }
        public static void EvenOrOddCheck(int num)
        {
            Func<int, bool> evenODD = (num) => num % 2 == 0;

            if (evenODD(num))
                Console.WriteLine(num+" Is Even");
            else
                Console.WriteLine(num+" is ODD");

        }
        public static void StringLength(string str1, string str2)
        {
            Func<string, string, bool> chekstring = (str1, str2) => str1.Length.Equals(str2.Length);

            if (chekstring(str1, str2))
                Console.WriteLine("String length are Equal");
            else
                Console.WriteLine("String length are Not Equal");

        }

        public static void  SwapValue<T>(T a, T b)
        {
            Console.WriteLine("Before swap: Value1="+a+" Value2="+b);

            T temp=a; 
            a = b; 
            b = temp;

            Console.WriteLine("After swap: Value1=" + a + " Value2=" + b);

        }

        public static void NumberTransform(List<int> numbers)
        {
            var processedNumbers = numbers.Select(n => n * 2).Where(n => n >= 10).ToList();
            processedNumbers.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();
        }
        public static void maxNumber(int num1,int num2) { 

        Func<int, int, int> max = (a, b) => a > b ? a : b;

        int result = max(num1, num2);

        Console.WriteLine($"The maximum of {num1} and {num2} is {result}");
        }










}
    public class DevideByZero : Exception
    {
        public   DevideByZero()
        {
            Console.WriteLine("Devide By zero Exception");
        }
    


    }
    public class InvalidInputFormat : Exception
    {
        public InvalidInputFormat()
        {
            Console.WriteLine("Invalid Input Format");
        }
    
    }
    public class ageValidator : Exception
    {
        public ageValidator()
        {
            Console.WriteLine("Age Shud Be less Than 0 or  Greter Than 150");

        }
    }
    public class InsufficientFundsException:Exception
    {
        public InsufficientFundsException()
        {
            Console.WriteLine("Withdrowal Money is less tha  balance ");
        }
    }
    public class ProductOutOfStockException : Exception
    {
        public ProductOutOfStockException()
        {
            Console.WriteLine("Product stock is 0");
        }
    }
    










}
