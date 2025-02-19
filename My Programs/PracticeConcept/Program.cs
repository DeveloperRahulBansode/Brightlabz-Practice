using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace PracticeConcept
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //Console.WriteLine("Enter Employee Details");
            //Console.WriteLine("Enter Employee ID :");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Employee Name :");
            //string name = Console.ReadLine();

            //Console.WriteLine("Employee Login...");
            //Console.WriteLine("Enter UserName Of Employee :");
            //String userID = Console.ReadLine();
            //Console.WriteLine("Enter Password of Employee :");
            //string pass = Console.ReadLine();
            //Console.WriteLine("Enter Employee Email Id");
            //string email = Console.ReadLine();

            //Console.WriteLine("Enter Employee Contact No");
            //string contact = Console.ReadLine();


            //var emp = new UserRegistration(id,name,userID,pass,email,contact);

            //var contax=new ValidationContext(emp);
            //var result=new List<ValidationResult>();
            //var isValid=Validator.TryValidateObject(emp, contax,result,true);

            //if (isValid) {

            //    Console.WriteLine();
            //    Console.WriteLine("Registration Sucessfully... ");
            //    Console.WriteLine();
            //    Console.WriteLine(emp.ToString());


            //}
            //else
            //{
            //    Console.WriteLine("Validation Errors");
            //    result.ForEach(error => Console.WriteLine("-> "+error.ErrorMessage));

            //}


            //Arithmatic operation = DelegatesDemo.multiplication;
            //operation += DelegatesDemo.Addition;

            //arithmatic<int> op = DelegatesDemo.add;
            //arithmatic<float> di = DelegatesDemo.Sub;
            //Console.WriteLine(op(10, 20));
            //Console.WriteLine(di(10.0F,20.0F));

            //Func<int,float,float> obj = DelegatesDemo.Div;
            //Console.WriteLine("return=" + obj(20, 20.0F));
            //obj(10,20.0F);

            ////operation(10,20);

            ////Func
            //Func<int, int, int> sum = Sum;
            //Console.WriteLine(sum(10,10));

            //Func<int,int,int> addi=(a,b)=>a+b;

            //Action<int, int> add = (a, b) => Console.WriteLine(a+b);

            //add(10,10);


            //Action<int> print=Console.WriteLine;
            //           print(addi(10,20));

            //Action<string> str = Console.WriteLine;






            //Predicate<Int32> a=a=>a%2==0; 
            //if (a.Invoke(3))
            //    str("Even");

            //else
            //    Console.WriteLine("Odd");


            //Predicate<string> isupper = isUppercase;
            //bool data = isupper("rahul");
            //Console.WriteLine(data);
            //Console.WriteLine();



            //Arithmatic Action Button
            while (true)
            {
                Console.WriteLine("Enter Number 1 ");
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number 2 ");
                int b = Int32.Parse(Console.ReadLine());

                Console.WriteLine("1-> Addition");
                Console.WriteLine("2-> Subtraction");
                Console.WriteLine("3-> Multiplication");
                Console.WriteLine("4-> Devision");
                Console.WriteLine("5-> Modulus");
                Console.WriteLine("6-> Exit");

                Console.WriteLine("Enter Your Choice");
                int choice = Int32.Parse(Console.ReadLine());
                Form form1 = new Form(choice);



                switch (choice)
                {
                    case 1: form1.Addition.IfButtonClicked(a, b); break;
                    case 2: form1.Subtraction.IfButtonClicked(a, b); break;
                    case 3: form1.Multiplication.IfButtonClicked(a, b); break;
                    case 4: form1.Division.IfButtonClicked(a, b); break;
                    case 5: form1.Modulus.IfButtonClicked(a, b); break;
                    case 6: Console.WriteLine("Bye Byee...."); break;
                    default: Console.WriteLine("Invalid Choice"); break;

                }

            }

            //    ClosuresDemo closuresDemo = new ClosuresDemo();
            //    var counter1=closuresDemo.CreateCounter();
            //    var counter2=closuresDemo.CreateCounter();

            //    Console.WriteLine(counter1());
            //    Console.WriteLine(counter1());
            //    Console.WriteLine(counter2());

            //    ClosuresDemo.ActionProceed();
            //    ClosuresDemo.program();

        }






        
        static int Sum(int a,int b)
        {
            return a + b;

        }

        static bool isUppercase(string msg)
        {
            return msg.Equals(msg.ToUpper());
        }
    }
}
