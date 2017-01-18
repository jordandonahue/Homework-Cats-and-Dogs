using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Cat : Animals
    {


        
        
        public Cat(string color, int age, string name, string gender, string breed)
        {
            this.color = color;
            this.age = age;
            this.name = name;
            this.gender = gender;
            this.breed = breed;
        }

       

        public string Describe()
        {
            return "Meow, Purr. This Cat is a " + this.age + " year old " + this.gender + " " + this.color + " " + this.breed + " named " + this.name;
        }
        
        public override string MakeNoise()
        {
            return "Meow";
        }
    }

    
    }

