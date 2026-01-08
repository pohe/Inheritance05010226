using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance05010226
{
    public interface IAnimalCollection
    {
        int Count { get;  }

        List<Animal> GetAll();
        void AddAnimal(Animal animal);
        Animal GetAnimal(string name); //Name er unikt
        void DeleteAnimal(string name);

        bool UpdateAnimal(string name, Animal uddateAnimal);

        void ShowAllAnimals();

    }
}
