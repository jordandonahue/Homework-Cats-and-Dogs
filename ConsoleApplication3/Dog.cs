using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Dog : Animals, IMammal
    {


        public Dog(int age, string name, string gender, string breed, string color)
        {
            this.age = age;
            this.name = name;
            this.gender = gender;
            this.breed = breed;
            this.color = color;
                       
        }

        public string Describe()
        {
            return "Woof, Bork. This Dog is a " + this.age + " year old " + this.gender + " " + this.color + " " + this.breed + " named " + this.name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void GiveLiveBirth()
        {
            Console.Write("Dog had Puppies!");
        }

        public string MakeNoise()
        {
            return "Woof!";
        }
    }
}
