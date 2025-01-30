using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGeneric
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;

        public int Id {

            get { return id; }
            set {

                if (id! >= 0 && id! <= 100)
                {
                    Console.WriteLine("Plz Inter valid id");
                }
                else
                {
                    this.id = value;
                }

            }

        }

        public Student() { }

        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;

        }

        public virtual string toString()
        {
            return "Student [ Student Id : "+id+", Student Name : "+name+", Student Age : "+age+" ]";
        }
      
       
    }
}
