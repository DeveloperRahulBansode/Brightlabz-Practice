using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConcept
{
    public delegate int OnButtonClicked(ArithmaticButton source, int a, int b);

    public class ArithmaticButton
    {
        public event OnButtonClicked? buttonHaldler;
        public string? buttonName;


        public ArithmaticButton(string buttonName)
        {
            this.buttonName = buttonName;
            Console.WriteLine("Operation : "+this.buttonName);
        }

        public void IfButtonClicked(int a,int b)
        {
            


            if (buttonHaldler != null) 
            {

                int result = buttonHaldler(this, a, b);

                Console.WriteLine($"Result Of {buttonName} : {result}");
               
                            
            } 
        }






    }
    public class Form
    {
        public ArithmaticButton Addition { get; set; }
        public ArithmaticButton Subtraction { get;set; }
        public ArithmaticButton Multiplication { get; set; }
        public ArithmaticButton Division { get; set; }
        public ArithmaticButton Modulus { get; set; }
        public int choice { get; set; }
        

        public Form(int choice) 
        {
            this.choice = choice;
            if (choice == 1)
            {
                this.Addition = new ArithmaticButton("AdditionButton");
                this.Addition.buttonHaldler += Addition_buttonHaldler;
            }
            else if (choice == 2)
            {

                this.Subtraction = new ArithmaticButton("SubtractionButton");
                this.Subtraction.buttonHaldler += Subtraction_buttonHaldler;
            }
            else if (choice == 3)
            {
                this.Multiplication = new ArithmaticButton("MultiplicationButton");
                this.Multiplication.buttonHaldler += Multiplication_buttonHaldler;
            }
            else if (choice == 4)
            {
                this.Division = new ArithmaticButton("DivisionButton");
                this.Division.buttonHaldler += Division_buttonHaldler;
            }
            else if (choice == 5)
            {
                this.Modulus = new ArithmaticButton("ModulusButton");
                this.Modulus.buttonHaldler += Modulus_buttonHaldler;
            }
        
        }

        private int Modulus_buttonHaldler(ArithmaticButton source, int a, int b)
        {
            return a % b;
        }

        private int Division_buttonHaldler(ArithmaticButton source, int a, int b)
        {
            return a / b;
        }

        private int Multiplication_buttonHaldler(ArithmaticButton source, int a, int b)
        {
            return a * b;
        }

        private int Subtraction_buttonHaldler(ArithmaticButton source, int a, int b)
        {
            return a - b;

        }

        private int Addition_buttonHaldler(ArithmaticButton source, int a,int b)
        {
            return a+b;
        }
    }
}
