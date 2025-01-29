using System;

namespace PracticeQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int choice;
            //do {
            //    choice = InputAndOutput.printManu();
            //    Console.WriteLine();   

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine();
            //            Console.WriteLine("You have selected 1");
            //            break;



            //    } 
                
            //} while (choice!=0);


            //Console.WriteLine();
            //Console.WriteLine("Goodbye!");
            SingleLinkList list = new SingleLinkList();

            list.addfirst("A");
            list.addfirst("B");
            list.addfirst("C");
            list.printList();
            list.addLast("D");
            list.printList();
           ;
        }
    }
}
