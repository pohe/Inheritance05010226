using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance05010226
{
    public class AnimalRepositoryDictionary : IAnimalCollection
    {
        private Dictionary<string, Animal> _animals;
        public AnimalRepositoryDictionary()
        {
            _animals = new Dictionary<string, Animal>();
        }
        public int Count { get { return _animals.Count; } }

        public void AddAnimal(Animal animal)
        {
            if( _animals.ContainsKey(animal.Name) )
            {
                throw new AnimalAllReadyExistException("Duplicate name");
            }
            _animals.Add(animal.Name, animal);
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
            _animals.Remove(name);
        }

        public List<Animal> FindAllAnimalsByColour(string colour)
        {
            throw new NotImplementedException();
        }

        public List<Animal> FindAnimalsByAgeInterval(int minAge, int maxAge)
        {
            List<Animal> animalList = new List<Animal>();
            //foreach(Animal a in _animals.Values)
            //{
            //    if ( a.Age >= minAge && a.Age <= maxAge)
            //    {
            //        animalList.Add(a);
            //    }
            //}

            //For
            //List<Animal> allAnimals = _animals.Values.ToList();
            //for(int i =0; i<allAnimals.Count;i++)
            //{
            //    if (allAnimals[i].Age >= minAge && allAnimals[i].Age <= maxAge)
            //    {
            //        animalList.Add(allAnimals[i]);
            //    }
            //}

            //While
            List<Animal> allAnimals = _animals.Values.ToList();
            int i = 0;
            while(i < allAnimals.Count )
            {
                if (allAnimals[i].Age >= minAge && allAnimals[i].Age <= maxAge)
                {
                    animalList.Add(allAnimals[i]);
                }
                i++;
            }
            
            
            
            
            return animalList;
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

        public bool UpdateAnimal(string name, Animal updateAnimal)
        {
            if ( _animals.ContainsKey(name))
            {
                DeleteAnimal(name);
                AddAnimal(updateAnimal);
                return true;
            }
            return false;
        }
    }
}
