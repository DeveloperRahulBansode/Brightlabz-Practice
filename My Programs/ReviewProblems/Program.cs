using System;
using System.Collections;
using System.Drawing;

namespace ReviewProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Q1
            //SwapTwoNumbers.SwapWithouteVariable(2, 4);

            ////Q2
            //Console.WriteLine();
            //TypeConversion.TypeConversionOfData();
            
            ////Q3
            //Console.WriteLine();
            //AccessModifiresClassess acess = new AccessModifiresClassess();
            //acess.publicMethod();
            ////acess.privateMethod();
            ////acess.protectedMethod();
            //acess.internalMethod();
            //acess.protectedInternalMethod();
            ////acess.privateProtectedMethod();
            


            ////Q5
            //FibonacciSeries.Display(10);


            ////Q6
            //Console.WriteLine();
            //MultiplicationTable.multiplicationOfTable(5);

            ////Q7
            //Console.WriteLine();
            ////Shapes shape= new Circlee(5);
            ////shape.DisplayInfo();

            //Shapes shape1 = new Circlee(5);
            //shape1.DisplayInfo();
            //shape1.CalculateArea();


            ////Q8
            //Console.WriteLine();
            //Circle circle = new Circle(10);
            //circle.DisplayInfo();

            //Rectangle rectangle = new Rectangle(5, 6);
            //rectangle.DisplayInfo();

            //Triangle triangle = new Triangle(5, 6);
            //triangle.DisplayInfo();


            //Q1 and Q2
            int[] intArray= {5,10,7,3,24,45};
            double[] doubleArray = {2.227,8.77,8.987,4.354,5.55,7.467 };
            float[] floatArray = { 2.5f, 5.5f, 6.2f, 5.7f, 8.8f };

            GenericMaxValue.FindMaxValueInArray(intArray);
            GenericMaxValue.FindMaxValueInArray(doubleArray);
            GenericMaxValue.FindMaxValueInArray(floatArray);



            //Q3 and Q4

            OverloadingAndOverriding.addition(50,60);
            OverloadingAndOverriding.addition(32.0f,50.5f);
           

            Addition add = new Addition(10,20);
            add.Calculator();


            //Q5
            List<Employee> employeeData = new List<Employee>();

            employeeData.Add(new Employee(1, "Rahul", 20));
            employeeData.Add(new Employee(2, "pratik", 24));
            employeeData.Add(new Employee(3, "naveen", 20));
            employeeData.Add(new Employee(4, "Rameshwar", 24));
            employeeData.Add(new Employee(5, "vishal", 20));
            employeeData.Add(new Employee(6, "Pranav", 24));

            foreach (Employee e in employeeData)
            {
                Console.WriteLine(e.ToString());
            }


            //remove
           employeeData.Remove(new Employee(6, "Pranav", 24));

            Console.WriteLine("Employee 6 Deleted" + "\n");

            foreach (Employee e in employeeData)
            {

               Console.WriteLine(e.ToString());
            }

            //Find 
            Employee? data = employeeData.FirstOrDefault(e => e.Id == 1);

            Console.WriteLine();
            Console.WriteLine("Employee Id 1 data Found="+data.ToString());


            //Q6
            Console.WriteLine();
            List<Student> stuData= new List<Student>();
            stuData.Add(new Student(1, "Rahul", 20));
            stuData.Add(new Student(2, "pratik", 24));
            stuData.Add(new Student(3, "naveen", 21));
            stuData.Add(new Student(4, "Rameshwar", 25));

            foreach (Student e in stuData)
            {
                Console.WriteLine(e.ToString());
            }

            var sortedStudentName = stuData.OrderBy(s => s.name);

            var sortedStudentAge = stuData.OrderBy (s => s.age);

            Console.WriteLine("---------------------Soeted name-------------------");
            foreach (var item in sortedStudentName)
            {
                Console.WriteLine(item.ToString());
            }


            Console.WriteLine("---------------------Soeted Age-------------------");
            foreach (var item in sortedStudentAge)
            {
                Console.WriteLine(item.ToString());
            }



            Console.WriteLine();

            Console.WriteLine("Even in List Of Data");
            //Q7
            var list = new List<int> { 1, 2, 3 };
            var enevnumber = list.Where(n => n % 2 == 0);
            foreach (int i in enevnumber) {
                Console.WriteLine(i);
            }



            //Q8
            List<String> Names = new List<String>();
            Names.Add("pratik");
            Names.Add("rahul");
            Names.Add("naveen");
            Names.Add("Vishal");

            Console.WriteLine();
            foreach (String s in Names)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            var sortname = Names.OrderDescending();

            foreach (var e in sortname)
            {
                Console.WriteLine(e);
            }









        }
    }
}
