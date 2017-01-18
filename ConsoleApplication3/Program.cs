using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            var cat = new Cat("Black and Brown", 3, "Beyonce", "Female", "Calico");
            var noise = cat.MakeNoise();
            Console.WriteLine(noise);

            var dog = new Dog(5, "Jeff", "Male", "Doberman", "Green");
            noise = dog.MakeNoise();
            Console.WriteLine(noise);
            
            List<Animals> animals = new List<Animals>();
            animals.Add(cat);
            animals.Add(dog);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.name);
            }

            //Cat cat = new Cat("Black and Brown", 3,"Beyonce","Female","Calico");
            //Dog dog = new Dog(5, "Jeff", "Male", "Doberman", "Green");

            //Console.WriteLine(cat.Describe());
            //Console.WriteLine(dog.Describe());

            Console.ReadKey();


        }
    }
}
