using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndNon_GenericCollections
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public Employee(int EmployeeID,string EmployeeName,int EmployeeAge)
        {
            this.Id = EmployeeID;
            this.Name = EmployeeName;
            this.Age = EmployeeAge;


        }

       



        public override string ToString() {
            return "Employee [ ID :"+Id+", Name :"+Name+", Age : "+Age+" ]";
        
        }


    }
}
