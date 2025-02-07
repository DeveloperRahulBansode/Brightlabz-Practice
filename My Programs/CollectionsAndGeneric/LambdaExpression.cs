using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGeneric
{

    internal class LambdaExpression
    {



        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
        public static List<LambdaExpression> GetAllEmployees()
        {
            List<LambdaExpression> listEmployees = new List<LambdaExpression>()
            {
                new LambdaExpression{ID= 101,Name = "Pooja", Salary = 10000, Department = "IT"},
                new LambdaExpression{ID= 102,Name = "Priyanka", Salary = 15000, Department = "Sales"},
                new LambdaExpression{ID= 103,Name = "Manoj", Salary = 25000, Department = "Sales"},
                new LambdaExpression{ID= 104,Name = "Santosh", Salary = 20000, Department = "IT"},
                new LambdaExpression{ID= 105,Name = "Vishal", Salary = 30000, Department = "IT"},
                new LambdaExpression{ID= 106,Name = "Sandhya", Salary = 25000, Department = "IT"},
                new LambdaExpression{ID= 107,Name = "Mahesh", Salary = 35000, Department = "IT"},
                new LambdaExpression{ID= 108,Name = "Manoj", Salary = 11000, Department = "Sales"},
                new LambdaExpression{ID= 109,Name = "Pradeep", Salary = 20000, Department = "Sales"},
                new LambdaExpression{ID= 110,Name = "Saurav", Salary = 25000, Department = "Sales"}

            };
            return listEmployees;
        }

        




        public void  LambdaDisplay() {
        
            var Sqrt=(int num)=>num*num;
            Console.WriteLine("Sqrt = "+Sqrt(5));
            
               
        }

        public override string ToString()
        {
            return "Data [Id = " + ID + ", Name= " + Name + ", salary= " + Salary + ",Department= " + Department + " ]";
        }

    }
}
