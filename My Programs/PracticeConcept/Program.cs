using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace PracticeConcept
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Employee Details");
            Console.WriteLine("Enter Employee ID :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Employee Login...");
            Console.WriteLine("Enter UserName Of Employee :");
            String userID = Console.ReadLine();
            Console.WriteLine("Enter Password of Employee :");
            string pass = Console.ReadLine();
            Console.WriteLine("Enter Employee Email Id");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Employee Contact No");
            string contact = Console.ReadLine();


            var emp = new UserRegistration(id,name,userID,pass,email,contact);

            var contax=new ValidationContext(emp);
            var result=new List<ValidationResult>();
            var isValid=Validator.TryValidateObject(emp, contax,result,true);

            if (isValid) {

                Console.WriteLine();
                Console.WriteLine("Registration Sucessfully... ");
                Console.WriteLine();
                Console.WriteLine(emp.ToString());


            }
            else
            {
                Console.WriteLine("Validation Errors");
                result.ForEach(error => Console.WriteLine("-> "+error.ErrorMessage));

            }






        }
    }
}
