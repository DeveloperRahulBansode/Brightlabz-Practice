using System.Drawing;

namespace ReviewProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Q1
            SwapTwoNumbers.SwapWithouteVariable(2, 4);

            //Q2
            Console.WriteLine();
            TypeConversion.TypeConversionOfData();
            
            //Q3
            Console.WriteLine();
            AccessModifiresClassess acess = new AccessModifiresClassess();
            acess.publicMethod();
            //acess.privateMethod();
            //acess.protectedMethod();
            acess.internalMethod();
            acess.protectedInternalMethod();
            //acess.privateProtectedMethod();
            


            //Q5
            FibonacciSeries.Display(10);


            //Q6
            Console.WriteLine();
            MultiplicationTable.multiplicationOfTable(5);

            //Q7
            Console.WriteLine();
            //Shapes shape= new Circlee(5);
            //shape.DisplayInfo();

            Shapes shape1 = new Circlee(5);
            shape1.DisplayInfo();
            shape1.CalculateArea();


            //Q8
            Console.WriteLine();
            Circle circle = new Circle(10);
            circle.DisplayInfo();

            Rectangle rectangle = new Rectangle(5, 6);
            rectangle.DisplayInfo();

            Triangle triangle = new Triangle(5, 6);
            triangle.DisplayInfo();




        }
    }
}
