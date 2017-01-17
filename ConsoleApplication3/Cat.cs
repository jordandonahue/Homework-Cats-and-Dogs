using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Cat
    {
        public string color { get; set; }

        public int age { get; set; }

        public string name { get; set; }

        public string gender { get; set; }
        
        public string breed { get; set; }

        
        
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
        
    }

    
    }

