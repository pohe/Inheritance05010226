using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance05010226
{
    public class AnimalRepositoryList : IAnimalCollection
    {
        private List<Animal> _animals;

        public AnimalRepositoryList()
        {
            _animals = new List<Animal>();
        }

        public int Count { get { return _animals.Count; } }

        public void AddAnimal(Animal animal)
        {
            if (animal!= null )
            {
                //Animal tempAnimal = GetAnimal(animal.Name);
                if (GetAnimal(animal.Name) != null)
                {
                    throw new AnimalAllReadyExistException("Animal name exist");
                }
                _animals.Add(animal);
            }
            else
            {
                throw new ArgumentException("Animal må ikke være null");
            }
        }

        public int CountAnimalsByColourFor(string colour)
        {
            int count = 0;
            for (int i = 0; i < _animals.Count; i++)
            {
                if (_animals[i].Colour.ToLower() == colour.ToLower())
                {
                    count++;
                }
            }
            return count;
        }

        public int CountAnimalsByColourForeach(string colour)
        {
            int count = 0;
            foreach (Animal a in _animals)
            {
                if (a.Colour == colour)
                    count++;
            }
            return count;
        }

        public int CountAnimalsByColourWhile(string colour)
        {
            int count = 0;
            int i = 0;
            while (i < _animals.Count)
            {
                if (_animals[i].Colour == colour)
                {
                    count++;
                }
                i++;
            }
            return count;
            // Animal animal = _animals[0];
            //while (animal.Colour == colour)
            //{
            //   count++;
            //}
            // return count;
        }


        public void DeleteAnimal(string name)
        {
            //1 udgave
            //foreach (Animal animal in _animals)
            //{
            //    if (animal.Name == name)
            //    {
            //        _animals.Remove(animal);
            //        return; //break
            //    }
            //}

            //2 udgave
            //for(int i =0; i < _animals.Count; i++)
            //{
            //    if (_animals[i].Name == name)
            //    {
            //        _animals.RemoveAt(i);
            //        return;
            //    }
            //}

            //3. udgave
            Animal animalToDelete = GetAnimal(name);
            if (animalToDelete != null)
            {
                _animals.Remove(animalToDelete);
            }



        }

        public List<Animal> FindAllAnimalsByColour(string colour)
        {
            List<Animal> animalsWithSpecColour = new List<Animal>();
            foreach(Animal a in _animals)
            {
                if ( a.Colour == colour)
                {
                    animalsWithSpecColour.Add(a);
                }
            }
            return animalsWithSpecColour;
        }

        public List<Animal> FindAnimalsByAgeInterval(int minAge, int maxAge)
        {
            List<Animal> animalAge = new List<Animal>();

            foreach(Animal a in _animals)
            {
                if (a.Age > minAge && a.Age < maxAge)
                {
                    animalAge.Add(a);
                }
            }
            return animalAge;
        }

        public List<Animal> FindAnimalsByNameContain(string text)
        {
            List<Animal> animaltext = new List<Animal>();
            for (int i = 0; i < _animals.Count; i++)
            {
                if (_animals[i].Name.Contains(text))
                {
                    animaltext.Add(_animals[i]);
                }
            }
            return animaltext;

        }

        public List<Animal> GetAll()
        {
            return _animals;
        }

        public Animal GetAnimal(string name)
        {
            foreach(Animal animal in _animals)
            {
                if (animal.Name == name)
                    return animal; 
            }
            return null;
        }

        public Animal GetOldestAnimal()
        {
            //1. udgave
            //Animal oldestAnimal = null;
            //int higestAge = 0;
            //foreach(Animal a in _animals)
            //{
            //    if ( a.Age > higestAge )
            //    {
            //        higestAge = a.Age;
            //        oldestAnimal = a; 
            //    }
            //}
            //return oldestAnimal;

            //2. udgave
            if (_animals.Count == 0)
                return null;
            Animal oldestAnimal = _animals[0];
            foreach (Animal a in _animals)
            {
                if(a.Age > oldestAnimal.Age)
                {
                    oldestAnimal = a; 
                }
            }
            return oldestAnimal;
        }

        public void ShowAllAnimals()
        {
            //udgave 1
            //foreach(Animal a in _animals)
            //{
            //    Console.WriteLine(a);
            //}

            //udgave 2
            //int i = 0;
            //while (i< _animals.Count)
            //{
            //    Console.WriteLine( _animals[i].ToString()  );
            //    i++;
            //}

            //Udgave 3
            for(int i =0; i < _animals.Count; i++)
            {
                Console.WriteLine(_animals[i].ToString());
            }


        }

        public bool UpdateAnimal(string name, Animal uddateAnimal)
        {
            //Udgave 1
            Animal animalToUpdate = GetAnimal(name);
            if (animalToUpdate == null)
                return false;
            //animalToUpdate = uddateAnimal; nb virker ikke
            animalToUpdate.Age = uddateAnimal.Age;
            animalToUpdate.Name = uddateAnimal.Name;
            animalToUpdate.Colour = uddateAnimal.Colour;
            return true;
        }
    }
}
