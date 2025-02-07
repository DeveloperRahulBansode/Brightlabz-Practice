using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionsAndGeneric
{
    internal class LINQPrograms
    {

        public static void EvenNumberFromList(List<int> list)
        {
            var data = list.Where(e => e % 2 == 0).ToList();
            List<int> Even = new List<int>();
            Even = data;
            Even.ForEach(e => Console.Write(e + " "));
            Console.WriteLine();

        }

        public static void FindString(List<string> list)
        {
            var data = list.Where(e => e.StartsWith("A")).ToList();
            data.ForEach(e => Console.Write(e + " "));



        }

        public static void SortInt(List<int> list)
        {
            var data = list.OrderByDescending(e => e).ToList();
            data.ForEach(e => Console.Write(e + " "));
        }


        public static void CheckGreterThan(List<int> list)
        {
            var data = list.Where(e => e > 50).ToList();
            data.ForEach(e => Console.Write(e + " "));
            Console.WriteLine();
        }



        public static void CheckStringCount(List<string> list)
        {

            var data = list.Count(e => e.Length > 5);
            Console.WriteLine(data);
            Console.WriteLine();
        }


        public static void CheckDistinct(List<int> Newlist)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var data = list.Concat(Newlist).Distinct().ToList();
            data.ForEach(e => Console.Write(e + " "));
            Console.WriteLine();
        }


        public static void SumOfOdd(List<int> list)
        {

            var data = list.Where(e => e % 2 != 0).ToList();
            data.ForEach(data => Console.Write(data + " "));
            var sum = data.Sum();
            Console.WriteLine("Sum OF This ODD=" + sum);

        }

        public static void FindMax(List<int> list)
        {
            var data = list.Max();
            Console.WriteLine("Maximum in List=" + data);

        }

        public static void SquareOfNumber(List<int> list)
        {
            var data = list.Select(e => e * e).ToList();
            list = new List<int>(data);
            list.ForEach(list => Console.Write(list + " "));
            Console.WriteLine();
        }

        public static void FindStringInclude(List<string> list)
        {
            var data = list.Where(e => e.EndsWith(".com")).ToList();
            data.ForEach(e => Console.WriteLine(e));
            Console.WriteLine();
        }


        //intermediat

        public static void StringOfFirstLetter(List<string> list)
        {
            var data = list.Select(list => list.First()).ToList();//return first element in List also use ElementAt(0)
            data.ForEach(list => Console.WriteLine(list));
        }


        public static void HighestThreeNumber(List<int> list)
        {

            var data = list.OrderByDescending(e => e).Take(3).ToList();
            data.ForEach(e => Console.Write(e + " "));
            Console.WriteLine();
        }


        public static void EmployeeSalary()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee(1,"Rahul",200000),
                new Employee(2,"pratik",100000),
                new Employee(3,"pranav",50000)
            };
            var data = list.Where(e => e.Salary > 50000).ToList();
            data.ForEach(e => Console.WriteLine(e));
        }

        public static void PositiveNumbers(List<int> list)
        {

            var data = list.Where(e => e > 0).ToList();
            data.ForEach(e => Console.Write(e + " "));
            Console.WriteLine();
        }

        public static void DivisablByThreeAndFiveNumbers(List<int> list)
        {

            var data = list.Find(e => e % 5 == 0 && e % 3 == 0);
            Console.WriteLine(data);
        }

        public static void CombineUniqueList(List<int> list)
        {

            var list2 = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var data = list.Union(list2).ToList();

            list = new List<int>();

            list = data;

            list.ForEach(e => Console.Write(e + " "));
            Console.WriteLine();

        }

        public static void PrintStudentNameViaMarks()
        {
            List<Students> students = new List<Students>()
            {
                new Students(1,"Rahul",95),
                new Students(2,"Pratik",90),
                new Students(3,"Pranav",80),
                new Students(4,"Vishal",75)
            };


            var data = students.Where(e => e.Marks > 80).ToList();
            data.ForEach(data => Console.Write(data.Name + " "));
            Console.WriteLine();

        }

        public static void LargestString(List<string> list)
        {

            var data = list.Max();
            Console.WriteLine(data);
        }

        public static void NotInStockProduct()
        {
            List<Product> products = new List<Product>()
            {
                new Product(1,"BoatEarbuts 280 ANC ","Out Of Stock"),
                new Product(2,"JBL earbuts pro","IN Stock"),
                new Product(3,"Boat headphones Black Clasic","In Stock"),
                new Product(4,"Oneplus EarPods 2r","Out Of Stock")
            };
            var data = products.FindAll(e => e.ProductStatus.Equals("Out Of Stock")).ToList();
            data.ForEach(data => Console.Write(data.ProductName + " ,"));
            Console.WriteLine();
        }

        public static void AverageOfFloat(List<float> list)
        {
            var data = list.Average();
            Console.WriteLine("Average Of Floating List :" + data);

        }

        //Advance

        public static void printDepartment()
        {
            List<Employees> employees = new List<Employees>()
            {
                new Employees(1,"Rahul",200000,"Computer"),
                new Employees(2,"Pratik",100000,"IT"),
                new Employees(3,"Pranav",50000,"ESTC"),
                new Employees(4,"Vinayak",50000,"IT")
            };
            //LINQ
            var data1 = employees.GroupBy(e => e.Department).Select(e => new { depart = e.Key, average = e.Average(a => a.Salary) });
            //SYNTAX
            var data = from e in employees group e by e.Department into x select new { depart = x.Key, average = x.Average(e => e.Salary) };

            foreach (var item in data1)
            {
                Console.WriteLine(item.depart + " = " + item.average);

            }
            foreach (var item in data)
            {
                Console.WriteLine(item.depart + " -> " + item.average);

            }
        }


        public static void SecHighestNumber(List<int> list)
        {
            var data = list.OrderByDescending(e => e).Skip(1).ToList();
            var data2 = data.Max(e => e);
            Console.WriteLine(" Second Largest Number in List= " + data2);

        }

        public static void CustomerOrder()
        {
            List<Order> orders = new List<Order>()
            {
                new Order(1,"Rahul","Computer",new DateTime(2024,10,05)),
                new Order(2,"Pratik","Laptops",new DateTime(2025,1,04)),
                new Order(3,"Pranav","Laptops",new DateTime(2025,1,10)),
                new Order(4,"Vinayak","Computer",new DateTime(2023,5,25))


            };
            var CurrentDate= DateTime.Now;

            var data1=orders.Where(e=> (CurrentDate-e.dt).Days<30).ToList();
            data1.ForEach(data1 => Console.WriteLine(data1));

            var data = from e in orders where (CurrentDate - e.dt ).Days< 30 select e;
            foreach (var item in data)
            {
                Console.WriteLine(item.ToString());
                
            }

        }

        public static void NestedList()
        {
            List<List<int>> list = new List<List<int>>()
            {
                new List<int> { 1, 2, 3, 4 },
                new List<int> {5,6,7,8,9 }
            };
            var data = list.SelectMany(e=>e).ToList();
            data.ForEach(e=>Console.Write(e+" "));
            Console.WriteLine();
        }

        public static void FilterDuplicateWords(string data)
        {
            var word = data.Split(" ");
            var duplicate=word.GroupBy(e=>e).Where(word=>word.Count()>1).Select(e=>e.Key).ToList();
            var list =new List<string>();
            list = duplicate;
            list.ForEach(e=>Console.WriteLine("->"+e));





        }
        public static void FilterMostDuplicateWords(string data)
        {
            var word = data.Split(" ");

            var duplicate=word.GroupBy(e=>e).OrderByDescending(e=>e.Count()).Select(e=>e.Key).Take(1).ToList();


            var list = new List<string>();

            list = duplicate;

            list.ForEach(e => Console.WriteLine("Most Friquent Word in Sentence is : "+e));
        
        }

        public class Order
        {
            public int OrderId { get; set; }
            public string CustomerName { get; set; }
            public string Items { get; set; }
            public DateTime dt { get; set; }

            public Order(int orderId, string customerName, string items, DateTime dateTime)
            {
                OrderId = orderId;
                CustomerName = customerName;
                Items = items;
                dt = dateTime;
            }



            public override string ToString()
            {
                return "Orders [ ID :" + OrderId + " , Name :" + CustomerName + " , Item :" + Items + ", Date :  "+dt+" ]";

            }

        

        }
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public static  List<Employee> employee { get; set; } = new List<Employee>();

            public Employee(int id, string name, int salary)
            {
                Id = id;
                Name = name;
                Salary = salary;
            }

            public static void adddata(int id, string name, int salary)
            {
                employee.Add(new Employee(id, name, salary));
            }

            public static void ptintList()
            {
                foreach (var item in employee)
                {
                    Console.WriteLine(item.ToString());
                    
                }
            }

            public override string ToString()
            {
                return "Employee [ Id :" + Id + " , Name :" + Name + " , Salary :" + Salary + " ]";
            }
        }
        public class Employees
        {

            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }

            public string Department { get; set; }


            public Employees(int id, string name, int salary, string department)
            {

                Id = id;
                Name = name;
                Salary = salary;
                Department = department;
            }


            public override string ToString()
            {
                return "Employee [ Id :" + Id + " , Name :" + Name + " , Salary :" + Salary + ", Departament :" + Department + " ]";
            }


        }

        public class Students
        {

            public int Id { get; set; }
            public string Name { get; set; }
            public int Marks { get; set; }


            public Students(int id, string name, int marks)
            {

                Id = id;
                Name = name;
                Marks = marks;


            }


            public override string ToString()
            {
                return "Employee [ Id :" + Id + " , Name :" + Name + " , Marks :" + Marks + " ]";
            }


        }

        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }

            public string ProductStatus { get; set; }


            public Product(int productId, string productName, string productStatus)
            {
                ProductId = productId;
                ProductName = productName;
                ProductStatus = productStatus;
            }

            public override string ToString()
            {

                return "Product [ Id :" + ProductId + " , Name :" + ProductName + " , Status :" + ProductStatus + " ]"; ;
            }


        }
    }
}
