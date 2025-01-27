using System.Security.Cryptography.X509Certificates;

namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog("black","Bark","5 feet","Tommy","Local" );
            //string data1= dog.toString();
            //Console.WriteLine(data1);


            //------------------------------- 24/01/2025 Friday------------------------------
            //Encapsulation
            //AreaOfRectange obj = new AreaOfRectange(5, 6);
            //double area = obj.AreaOfRecta();
            //Console.WriteLine("Area Of Reactangle= "+area);

            //Person person = new Person();
            //person.setName("John");
            //person.setAge(-25);
            //person.print();


            //Inheritance
            //Cat cat = new Cat( "Meow", "Meow");
            //cat.MakeSound();

            //Circle circle = new Circle(40);
            //circle.GetArea();
            //Rectangle rectangle = new Rectangle(40, 50);
            //rectangle.GetArea();



            //Polymorphisam
            //Calculator addition = new Calculator();
            //addition.add(89,80);
            //addition.add(40, 20, 70);

            Payment pay = new Payment();
            pay.ProcessPayment();
            //CreditCardPayment amount = new CreditCardPayment(50000);
            //amount.ProcessPayment();
            CashPayment cash = new CashPayment(10000);
            cash.ProcessPayment();

            Payment pay1 = new CreditCardPayment(80000);
            pay1.Balance = 200000;
            pay1.ProcessPayment();
            

            //Abstraction

            //Vahical car = new Car();
            //car.StartEngine();
            //Vahical bike = new Bike();
            //bike.name= "Honda";
            //bike.StartEngine();



        }
    }
}
