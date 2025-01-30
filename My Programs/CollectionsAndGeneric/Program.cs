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



            List<Student> list2 = new List<Student>();
            list2.Add(new Student(1, "rahul", 24));
            list2.Add(new Student(2, "Naveen", 20));
            list2.Add(new Student(3, "lakshmiPriya", 20));
            list2.Add(new Student(4, "Pranita", 20));
            foreach (var item in list2)
            {
                Console.WriteLine(item.toString());

            }

            LinkedList<Student> students = new LinkedList<Student>();
            students.AddLast(new Student(1, "Rahul", 24));
            students.AddLast(new Student(2, "Priya", 22));
            students.AddFirst(new Student(0, "Naveen", 20));

            foreach (Student student in students)
            {
                Console.WriteLine(student.toString());
            }


            Student[] students2 = new Student[5];
            students2[0] = new Student(1, "hdhd", 20);


            Stack<Student> stack = new Stack<Student>();

            // Push (Add)
            stack.Push(new Student(1, "Rahul", 24));
            stack.Push(new Student(2, "Priya", 22));

            // Pop (Remove)
            Console.WriteLine("Popped: " + stack.Pop().toString());

            stack.Push(new Student(3, "Priya", 22));

            // Peek (Get Last Inserted Without Removing)
            Console.WriteLine("Top of Stack: " + stack.Peek().toString());
            stack.Push(new Student(4, "Priya", 22));

            // Count
            Console.WriteLine("Stack Count: " + stack.Count);






        }
    }
}
