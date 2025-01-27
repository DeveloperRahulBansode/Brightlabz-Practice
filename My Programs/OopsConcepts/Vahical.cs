using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public abstract class Vahical
    {
       
        public string name;

        public abstract void StartEngine();





    }

    public class Car : Vahical
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car Engine Started");
        }


    }

    public class Bike : Vahical
    {


        public override void StartEngine() { 
        
        Console.WriteLine("Bike Engine Started");
        
        
        
        }

    }
}
