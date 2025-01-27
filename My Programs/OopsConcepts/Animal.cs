using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace OopsConcepts
{
    public class Animal
    {

        public string _Voice;

        public Animal(string Voice)
        {
            _Voice = Voice;
            Console.WriteLine("this is voice of Animal");
        }


        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Sound= " + _Voice);
        }

    }

    public class Cat : Animal
    {


        string sound;

        public Cat(string sound, string Voice) : base(Voice)
        {
            this.sound = sound;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cat Sound= " + sound);
        }



    }

    

    
}
