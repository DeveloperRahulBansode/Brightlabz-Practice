using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public class OverloadingAndOverriding
    {

        public virtual void Calculator()
        {

            Console.WriteLine("Thsi is Empty Calculator Method");




                
         }
        public  static void addition(int number1,int number2)
        {
            var Result=number1 + number2;
            Console.WriteLine("Addition Of Integers= "+Result);
            


        }
        public static void addition(float number1, float number2)
        {
            var Result = number1 + number2;
            Console.WriteLine("Addition Of Float= "+Result);



        }





    }
    public class Addition : OverloadingAndOverriding
    {
        int number1;
        int number2;

        public Addition(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;

        }

        public  override void Calculator() {

            var result = number1 + number2;
            Console.WriteLine("Addition of Overrided method Calculator= "+result);
        
        }








    }

}
