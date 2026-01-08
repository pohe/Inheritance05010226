using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance05010226
{
    public abstract class Animal
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public int Age { get; set; }

        public string Colour { get; set; }
        protected Animal(string name, int age, string colour)
        {
            _name = name;
            Age = age;
            Colour = colour;
        }
        //public virtual void Speak()
        //{
        //    Console.WriteLine("Dyret siger lyde");
        //}

        public abstract void Speak();

        public override string ToString()
        {
            return $"Name {_name} age {Age}";
        }

    }
}
