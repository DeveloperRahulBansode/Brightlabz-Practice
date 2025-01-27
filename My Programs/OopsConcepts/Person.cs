using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Person
    {
        private string _name;
        private int _age;

        public Person() { }


      

        public void setName(string _name)
        {
            this._name=_name;
        }
        public string getName()
        {
            return _name;
        }

        public void setAge(int _age)
        {
            if (_age < 0)
            {
                Console.WriteLine("Age not be nagative");
                _age = 0;
            }
            else
                this._age = _age;
        }
        public int getAge()
        {
            return _age;
        }







        public void print()
        {
            Console.WriteLine("Name= " + _name + " Age= " +_age);
        }






    }
}
