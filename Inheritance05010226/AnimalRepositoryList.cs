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
                _animals.Add(animal);
            }
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
