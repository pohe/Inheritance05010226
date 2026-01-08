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


        //søgning - får typisk et objekt tilbage

        Animal GetOldestAnimal();  //returnerer et animal med den højeste alder

        //Søge funktion

        int CountAnimalsByColourFor(string colour);
        int CountAnimalsByColourWhile(string colour);
        int CountAnimalsByColourForeach(string colour);
        //Filtrering

        List <Animal> FindAllAnimalsByColour(string colour);

        List<Animal> FindAnimalsByAgeInterval(int minAge, int maxAge);

        List<Animal> FindAnimalsByNameContain(string text);


    }
}
