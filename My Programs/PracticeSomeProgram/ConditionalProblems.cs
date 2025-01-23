using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSomeProgram
{
    internal class ConditionalProblems
    {
        public static void CheckGrade()
        {
            Console.WriteLine("Enter the marks of the student: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks >= 90 && marks<=100)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks >= 80 && marks < 90)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks >= 70 && marks < 80)
            {
                Console.WriteLine("Grade C");
            }
            else if (marks >= 60 && marks < 70)
            {
                Console.WriteLine("Grade D");
            }
            else if(marks>=0 && marks<60 )
            {
                Console.WriteLine("Grade F");
            }
        }


        public static void ConvertTemprature()
        {
            Console.WriteLine("1 --> Fahrenheit to Celsius");
            Console.WriteLine("2 --> Celsius to Fahrenheit");

            Console.WriteLine("Enter your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the temprature in Fahrenheit: ");
                    double fahrenheitValue = Convert.ToDouble(Console.ReadLine());
                    double celsius = (fahrenheitValue - 32) / 1.8;
                    Console.WriteLine("Temprature in Celsius: " + celsius+"C'");
                    break;

                case 2:
                    Console.WriteLine("Enter the temprature in Celsius");
                    double celsiusValue = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = (celsiusValue * 1.8) + 32;
                    Console.WriteLine("Temprature in Fahrenheit: " + fahrenheit+"F'");
                    break;

                default: Console.WriteLine("Invalid Choice");
                    break;

            }
                    
        }

        public static void CalculateMovieTicketPrice()
        {
            Console.WriteLine("Enter the age of the person: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time of the show: ");
            int time = Convert.ToInt32(Console.ReadLine());
            int ticketPriceForAdults = 300;
            int ticketPriceForChildren = 200;
            int ticketPriceForSeniorCitizens = 250;


            if (age >= 5 && age <= 12)
            {
                if (time >= 5 && time <= 8)
                {
                    Console.WriteLine("Ticket Price: " + ticketPriceForChildren);
                }
                else
                {
                    Console.WriteLine("Ticket Price: " + ticketPriceForChildren);
                }
            }
            else if (age >= 12 && age < 65)
            {
                if (time >= 5 && time <= 8)
                {
                    Console.WriteLine("Ticket Price: " + ticketPriceForAdults);
                }
                else
                {
                    Console.WriteLine("Ticket Price: " + ticketPriceForAdults);
                }
            }
            else if(age>65) 
            {
                if (time >= 5 && time <= 8)
                {
                    Console.WriteLine("Ticket Price: " + ticketPriceForSeniorCitizens);
                }
                else
                {
                    Console.WriteLine("Ticket Price: " + ticketPriceForSeniorCitizens);
                }
            }
                      
        }



        public static void UserLogin()
        {
            

            Console.WriteLine("Enter the username: ");
            string userName = Console.ReadLine();

            if (userName == "Rahul")
            {

                Console.WriteLine("Enter the password: ");
                string password = Console.ReadLine();
                if (password == "12345")
                {
                    Console.WriteLine("Enter the SecrateCode: ");
                    string SecrateCode = Console.ReadLine();
                    if (SecrateCode == "Rahul12345")
                    {
                        Console.WriteLine("Successfully Login :" + userName);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect SecrateCode Accout Is Blocked");
                    }

                }else
                Console.WriteLine("Incorrect Password");

            }else
            Console.WriteLine("Incorrect UserName");

        }


    }
}
