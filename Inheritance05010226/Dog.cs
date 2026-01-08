using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance05010226
{
    public class Dog:Animal
    {
        public string Breed { get; set; }
        public Dog(string name, int age, string breed, string colour):base(name, age, colour)
        {
            Breed = breed;
        }

        public override void Speak()
        {
            Console.WriteLine("Vov vov");
        }
        public override string ToString()
        {
            return base.ToString() + $" breed {Breed}";
        }
    }
}
