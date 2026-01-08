using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance05010226
{
    public class Cat : Animal
    {
        public bool IsInDoor { get; set; }
        public Cat(string name, int age, bool isIndoor, string colour) : base(name, age, colour)
        {
            IsInDoor = isIndoor;
        }

        public override void Speak()
        {
            Console.WriteLine("Miauw miauw");
        }

        public override string ToString()
        {
            return base.ToString() + $" isindoor {IsInDoor}";
        }
    }
}
