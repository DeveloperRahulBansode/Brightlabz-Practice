using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PracticeSomeProgram
{
    internal class Employee
    {

        public static void EmployeeAttendanceCheck()
        {
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }


        }

        public static void EmployeeWage()
        {
            int FullDayHour = 8;
            int WagePerHour = 20;

            int empWage = FullDayHour * WagePerHour;
            Console.WriteLine("Employee Wage: " + empWage);
        }

        public static void PartTimeEmployeeWage()
        {
            int PartTimeHour = 8;
            int WagePerHour = 10;

            
            int empWage = PartTimeHour * WagePerHour;
            Console.WriteLine("Part Time Employee Wage: " + empWage);
        }

        public static void WegeForMonth()
        {
            int FullDayHour = 8;
            int WagePerHour = 20;

            int WorkingDays = 20;

            int empWage = FullDayHour * WagePerHour * WorkingDays;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    
        

        public static void WageForMonthOrHour()
        {
            int FullDayHour = 100;
            int WagePerHour = 20;

            int WorkingDays = 20;

            int empWage = FullDayHour * WagePerHour * WorkingDays;
            Console.WriteLine("Employee WageForMonthOrHour: " + empWage);
        }
    



        public static void UsingSwitchCase()
        {
            while (true)
            {
                Console.WriteLine("1 --> Check Employee is Present Or Not");
                Console.WriteLine("2 --> Calculate Employee Wage");
                Console.WriteLine("3 --> Add Part time Employee & Wage");
                Console.WriteLine("4 --> Calculate Wages for Month");
                Console.WriteLine("5 --> Calculate Wages till Condition of Total working hours or Day is reched for a month");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        EmployeeAttendanceCheck();
                        break;
                    case 2:
                        EmployeeWage();
                        break;
                    case 3:
                        PartTimeEmployeeWage();
                        break;
                    case 4:
                        WegeForMonth();
                        break;
                    case 5:
                        WageForMonthOrHour();
                        break;
                    case 0:
                        Console.WriteLine("Tata Bye..Byeee!!!");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }





        }


    }
}
