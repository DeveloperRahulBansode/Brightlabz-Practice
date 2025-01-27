using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class InheritanceAnimal
    {
        public string color { get; set; }
        public string voice { get; set; }
        public string height { get; set; }

        public InheritanceAnimal() { }     
        public InheritanceAnimal(string color, string voice, string height)
        {
            this.color = color;
            this.voice = voice;
            this.height = height;
        }

        

        public  virtual string toString()
        {
            return "  ANIMAL [Color="+color+",Voice="+voice+",Height="+height+"]";
        }



    }

    public class Dog : InheritanceAnimal
    {

        public String name { get; set; }
        public String breed { get; set; }

        public Dog() { }
        public Dog(string color, string voice, string height, string name, string breed) : base(color, voice, height)
        {
            this.name = name;
            this.breed = breed;
        }

        public  override string toString()
        {
            return "Dog [Name="+name+",Breed="+breed+" "+base.toString()+"]";
        }



    }
}
