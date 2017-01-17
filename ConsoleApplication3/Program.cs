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
            Cat cat = new Cat("Black and Brown", 3,"Beyonce","Female","Calico");
            Dog dog = new Dog(5, "Jeff", "Male", "Doberman", "Green");

            Console.WriteLine(cat.Describe());
            Console.WriteLine(dog.Describe());

            Console.ReadKey();


        }
    }
}
