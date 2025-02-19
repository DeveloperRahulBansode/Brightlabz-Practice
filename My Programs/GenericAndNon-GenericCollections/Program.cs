namespace GenericAndNon_GenericCollections
{
    internal class Program
    {
        static List<Employee> employeeData = new List<Employee>();
        public static void Main(string[] args)
        {
            //addEmployee(new Employee(1, "Rahul", 20));
            //addEmployee(new Employee(2, "pratik", 24));
            //addEmployee(new Employee(3, "naveen", 20));
            //addEmployee(new Employee(4, "Rameshwar", 24));
            //addEmployee(new Employee(5, "vishal", 20));
            //addEmployee(new Employee(6, "Pranav", 24));
            //printEmployee();


            //updateEmployee(3, "naveen", 21);
            //printEmployee();

            //deleteEmployee(4);
            //printEmployee();


            Qustions.EvenOrOddNumber(20);
            Qustions.equalString("rahul", "rahul");
            Qustions.stringPalyndrom("mam");

            //delegets
            Calculate cal = new Calculate(Qustions.addData);
            cal(10, 20);

            Console.WriteLine();
            Dictionary<int, Calculate> calc = new Dictionary<int, Calculate>()
            {
                {1,Qustions.addData },
                {2,Qustions.subData }
            };


            while (true) 
            {
                Console.WriteLine(" -Operatios List-");

                Console.WriteLine("1. Add Two Numbers");
                Console.WriteLine("2. Subtract Two Numbers");

                Console.WriteLine("Enter Your Choice=");
                int choice =Int32.Parse(Console.ReadLine());

                if (calc.ContainsKey(choice)) 
                {
                    calc[choice](10,20);

                    if(choice==3) break;

      
                }
                else
                {
                    Console.WriteLine("InValid Choice");
                }
            
            
            
            }



              


        }
        static void addEmployee(Employee employee)
        {
            employeeData.Add(employee);
        }

        //static void printEmployee() => employeeData.ForEach(s => s.ToString());
        static void printEmployee()
        {
            foreach (Employee e in employeeData)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine();
        }

        static void updateEmployee(int id,string Newname,int Newage)
        {
            Employee? employee = employeeData.FirstOrDefault(e=>e.Id==id);
            if (employee != null) {
            
                employee.Name = Newname;
                employee.Age = Newage;
                 
                Console.WriteLine("Employee ID: " + id + " Successfully Updated...."+"\n");
            }
            else
            {
                Console.WriteLine("Employee ID: "+id+ " NOT FOUND !! "+"\n");
            }


        }

        //static void deleteEmployee(int IdForDelete) => employeeData.RemoveAll(e => e.Id == IdForDelete);
        static void deleteEmployee(int IdForDelete)
        {
            Employee? employee = employeeData.FirstOrDefault(e => e.Id == IdForDelete);

            if (employee != null) { 
            
            employeeData.Remove(employee);

                Console.WriteLine("Employee ID: "+IdForDelete+" Successfully Deleted....."+"\n");
            
            }
            else
            {
                Console.WriteLine("Employee ID: " + IdForDelete + " NOT FOUND !! " + "\n");
            }

        }



       





    }

}
