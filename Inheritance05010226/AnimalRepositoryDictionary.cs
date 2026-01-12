using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance05010226
{
    public class AnimalRepositoryDictionary : IAnimalCollection
    {
        public int Count => throw new NotImplementedException();

        public void AddAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        public int CountAnimalsByColourFor(string colour)
        {
            throw new NotImplementedException();
        }

        public int CountAnimalsByColourForeach(string colour)
        {
            throw new NotImplementedException();
        }

        public int CountAnimalsByColourWhile(string colour)
        {
            throw new NotImplementedException();
        }

        public void DeleteAnimal(string name)
        {
            throw new NotImplementedException();
        }

        public List<Animal> FindAllAnimalsByColour(string colour)
        {
            throw new NotImplementedException();
        }

        public List<Animal> FindAnimalsByAgeInterval(int minAge, int maxAge)
        {
            throw new NotImplementedException();
        }

        public List<Animal> FindAnimalsByNameContain(string text)
        {
            throw new NotImplementedException();
        }

        public List<Animal> GetAll()
        {
            throw new NotImplementedException();
        }

        public Animal GetAnimal(string name)
        {
            throw new NotImplementedException();
        }

        public Animal GetOldestAnimal()
        {
            throw new NotImplementedException();
        }

        public void ShowAllAnimals()
        {
            throw new NotImplementedException();
        }

        public bool UpdateAnimal(string name, Animal uddateAnimal)
        {
            throw new NotImplementedException();
        }
    }
}
