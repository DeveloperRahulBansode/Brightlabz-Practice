using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace PracticeSomeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------- 21/01/2025 tuesday---------------------------------------

            //ConditionalStatements.IfStatement();
            //ConditionalStatements.IfelseStatement();
            //ConditionalStatements.IfelseIfStatement();
            //ConditionalStatements.NestedIfStatement();
            //ConditionalStatements.SwitchCaseStatement();
            //LoopingStatements.ForLoop();
            //LoopingStatements.WhileLoop();
            //LoopingStatements.DoWhileLoop();
            //LoopingStatements.NestedLoop();

            //------------------- 22/01/2025 wednesday----------------------------------------
            //CalculatelenghtofLine.CalculateLength();
            //EqualLineOrNot.EqualLine();
            //CompareTwoLine.CompareTwoLines();

            //Employee.UsingSwitchCase();

            //------------------- 23/01/2025 thursday----------------------------------------
            //ConditionalProblems.CheckGrade();
            //ConditionalProblems.ConvertTemprature();
            //ConditionalProblems.CalculateMovieTicketPrice();
            //ConditionalProblems.UserLogin();
            //ConditionalProblems.ConditionalProblemsUsingSwitch();


            //Linked List
            //LinkedList list= new LinkedList();
            //list.addHead(10);
            //list.addHead(20);
            //list.addHead(30);
            //list.addHead(40);
            //list.printList();

            //list.addlast(50);
            //list.printList();

            //list.deleteNode(30);
            //list.printList();
            //list.updateNode(20, 25);
            //list.printList();


            ;

            //LinkedList list1 = new LinkedList();

            //while (true)
            //{

            //    Console.WriteLine("1. Add Node at Head");
            //    Console.WriteLine("2. Add Node at Last");
            //    Console.WriteLine("3. Delete Node");
            //    Console.WriteLine("4. Update Node");
            //    Console.WriteLine("5. Print List");
            //    Console.WriteLine("6. Exit");


            //    Console.WriteLine("Enter Your Choice");
            //    int choice = Convert.ToInt32(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter the data to add at Head");
            //            int data = Convert.ToInt32(Console.ReadLine());
            //            list1.addHead(data);
            //            list1.printList();
            //            break;

            //        case 2:
            //            Console.WriteLine("Enter the data to add at Last");
            //            int data1 = Convert.ToInt32(Console.ReadLine());
            //            list1.addlast(data1);
            //            list1.printList();
            //            break;
            //        case 3:
            //            Console.WriteLine("Enter the data to delete");
            //            int data2 = Convert.ToInt32(Console.ReadLine());
            //            list1.deleteNode(data2);
            //            list1.printList();
            //            break;

            //        case 4:
            //            Console.WriteLine("Enter the data to update");
            //            int data3 = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enter the new data");
            //            int data4 = Convert.ToInt32(Console.ReadLine());
            //            list1.updateNode(data3, data4);
            //            list1.printList();
            //            break;
            //        case 5:
            //            list1.printList();
            //            break;
            //        case 6:
            //            Environment.Exit(0);
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Choice");
            //            break;






            //        }
            //    }

            //Exception Handling 

            //ExceptionHandlingDemo obj = new ExceptionHandlingDemo();
            //obj.denominator = 0;
            //obj.numerator = 20;

            //try
            //{
            //    obj.Calculation();

            //}
            //catch (DevideByZero) { }


            //Annotations

            

            Console.WriteLine("Student Details");
            Console.WriteLine("Enter Student ID :");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name :");
            string name= Console.ReadLine();
            Console.WriteLine("Enter Student Email Address");
            string email= Console.ReadLine();

            var student = new Student()
            {
                Id = id,
                Name = name,
                Email=email

            };


            var context=new ValidationContext(student);
            var result=new List<ValidationResult>();
            bool isValid=Validator.TryValidateObject(student, context,result,true);
            if (isValid)
            {
                Console.WriteLine("Employee Details Is Valid");
            }
            else
            {
                Console.WriteLine("Validation Errors");
                foreach (var error in result) {
                    Console.WriteLine($"->{error.ErrorMessage}");
                
                }

            }

            






        }
    }
}
