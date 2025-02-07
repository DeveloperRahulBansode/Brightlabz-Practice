using System;
using System.Collections;
using System.IO;
using System.Net.Http.Headers;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace CollectionsAndGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StackDemo.stackdemo();

            //GenericProblems.FindMax(10, 80, 30);
            //GenericProblems.FindMax(10.5, 20.5, 30.5);
            //GenericProblems.FindMax("rahul", "vishal", "naveen");
            //GenericProblems.FindMax('a', 'b', 'c');

            //GenericProblems.swapTwoNumbers(10,20);

            //ArrayList

            // void Display<T>(T[] i)
            //{
            //    Console.WriteLine(i.ToArray());
            //}

            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);


            //Console.WriteLine("Print List");
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Average List");
            //int data =(int)list.Average();
            //Console.WriteLine(data);

            //int data1=list.Count();
            //Console.WriteLine(data1);



            //foreach(int t in list)
            //    Console.WriteLine(t);

            //foreach (int i in list)
            //    { Console.WriteLine(i); }
            //Console.WriteLine();


            ///
            //  List<Student> data = new List<Student>();
            //  data.Add(new Student(1, "rahul", 24));
            //  data.Add(new Student(2, "Naveen", 20));
            //  data.Add(new Student(3, "lakshmiPriya", 20));
            //  data.Add(new Student(4, "Pranita", 20));
            //  foreach (var item in data)
            //  {
            //      Console.WriteLine(item.ToString());

            //  }
            //  data.RemoveAt(2);

            //  SortedList<int,Student> value=new SortedList<int, Student>();

            //  value.Add(1, new Student(1,"rahul",20));
            //  value.Add(2, new Student(2,"pratik",24)); 
            //  value.Add(3, new Student(3,"Pranav",25));

            //  value.Remove(3);

            //  foreach (var item in value)
            //  {
            //      Console.WriteLine(item);
            //  }

            //  Dictionary<int, Student> keyVallue= new Dictionary<int, Student>();


            //  Stack<Student> stack= new Stack<Student>();

            //  stack.Push(new Student());
            //  stack.Pop();


            //HashSet<Student> keys= new HashSet<Student>();

            //  //LambdaExpression lambda = new();
            //  //lambda.LambdaDisplay();
            //  Console.WriteLine();

            //  LambdaExpression.GetAllEmployees().ForEach(data => Console.WriteLine(data.ToString()));
            //  LambdaExpression.GetAllEmployees().Add(new LambdaExpression { ID = 111, Name = "Pooja", Salary = 10000, Department = "IT" });

            //  Func<float, float> multiply = (num) => num * 50.20F;
            //  Console.WriteLine(multiply(50));



            //LINQ Programs

            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            LINQPrograms.EvenNumberFromList(list);
            Console.WriteLine();

            List<string> list2 = new List<string>() { "Rahul", "Aman", "Arman", "Rameshwar", "Aakash" };
            LINQPrograms.FindString(list2);
            Console.WriteLine();

            Console.WriteLine();
            List<int> list3 = new List<int>(){ 1,2,3,4,6,7,8,9,10};
            LINQPrograms.SortInt(list3);
            Console.WriteLine();

            Console.WriteLine();
            list = new List<int>() { 100, 24, 35, 55, 89, 120, 40, 65 };
            LINQPrograms.CheckGreterThan(list);

            Console.WriteLine();
            List<string> list4 = new List<string>() { "Rahul", "Aman", "Arman", "Rameshwar", "Aakash" };
            LINQPrograms.CheckStringCount(list4);

            Console.WriteLine();
            list = new List<int>() { 1,11,3,20,22,6,7,8,9,10};
            LINQPrograms.CheckDistinct(list);

            Console.WriteLine();
            list=new List<int> { 1,2,3,4,5,6,7,8,9,10};
            LINQPrograms.SumOfOdd(list);

            Console.WriteLine();
            list = new List<int>() { 55, 85, 71, 30, 25, 01, 85 };
            LINQPrograms.FindMax(list);

            Console.WriteLine();
            list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            LINQPrograms.SquareOfNumber(list);


            Console.WriteLine();
            list4 = new List<string>() { "www.google.com", "www.mkcl.org", "www.w3school.edu", "www.yahoo.com", "www.gmail.com" };
            LINQPrograms.FindStringInclude(list4);


            //Intermediat
            Console.WriteLine();
            list4 = new List<string>() { "Rahul", "Aman", "Arman", "Rameshwar", "Aakash" };
            LINQPrograms.StringOfFirstLetter(list4);



            Console.WriteLine();
            list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            LINQPrograms.HighestThreeNumber(list);

            Console.WriteLine();
            LINQPrograms.EmployeeSalary();


            Console.WriteLine();
            list= new List<int>() { 1,-2,-4,6,-4,8,-7,3,9 };   
            LINQPrograms.PositiveNumbers(list);

            Console.WriteLine();
            list = new List<int>() {25,9,22,35,12,15,82,30,77 };
            LINQPrograms.DivisablByThreeAndFiveNumbers(list);


            Console.WriteLine();
            list = new List<int>() { 1, 2, 3, 4, 7, 8, 9, 10, 11 };
            LINQPrograms.CombineUniqueList(list);

            Console.WriteLine();
            LINQPrograms.PrintStudentNameViaMarks();


            Console.WriteLine();
            list4 = new List<string>() { "Rahul", "Aman", "Arman", "Rameshwar", "Aakash" };
            LINQPrograms.LargestString(list4);

            Console.WriteLine();
            LINQPrograms.NotInStockProduct();

            Console.WriteLine();
            List<float> fList = new List<float> { 1.5f,5.5f,6.3f,9.2f,8.88f };
            LINQPrograms.AverageOfFloat(fList);

            Console.WriteLine();
            LINQPrograms.printDepartment();

            Console.WriteLine();
            list = new List<int>() { 1,2,3,4,5,6,7,8,9};

            LINQPrograms.SecHighestNumber(list);


            Console.WriteLine();
            LINQPrograms.CustomerOrder();


            //LINQPrograms.Employee.adddata(1, "rahul", 50000);
            //LINQPrograms.Employee.ptintList();


            Console.WriteLine();
            LINQPrograms.NestedList();

            Console.WriteLine();
            LINQPrograms.FilterDuplicateWords("Fear leads  anger anger leads to hatred hatred leads to conflict conflict leads to suffering");

            Console.WriteLine();
            LINQPrograms.FilterMostDuplicateWords("Fear leads anger leads to hatred hatred leads to conflict conflict leads to suffering");



        }
    }
    
}
