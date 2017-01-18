﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Dog : Animals
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

        public override string MakeNoise()
        {
            return "Woof!";
        }
    }
}
