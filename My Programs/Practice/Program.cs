using System;

namespace PracticeQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do {
                choice = InputAndOutput.printManu();
                Console.WriteLine();   

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("You have selected 1");
                        break;



                } 
                
            } while (choice!=0);

        }
    }
}
