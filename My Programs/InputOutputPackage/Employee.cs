using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputPackage
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


        public Employee() { }

        public Employee(int id, string name, string email) 
        {
            Id = id;
            Name = name;
            Email = email;
        }



        public override string ToString()
        {
            return $"Employee [ Id: {Id} , Name: {Name} , Email: {Email} ]";
        }
    }
}
