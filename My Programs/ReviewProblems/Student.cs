﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    internal class Student
    {
        public int id {  get; set; }
        public string name {  get; set; }
        public int age {  get; set; }



        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;

        }

        public override string ToString()
        {
            return "Student [ Student Id : " + id + ", Student Name : " + name + ", Student Age : " + age + " ]";
        }
    }
}
