using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Calculator
    {
        public Calculator() { }

        public void add(double a,double b) { 
        
            
            Console.WriteLine("Addition of Two parameters= " + (a+b));
        }

        public void add(Double a, Double b,double c) { 

            Console.WriteLine("Addition Of Three Variable=" +(a+b+c));    
        }



    }
}
