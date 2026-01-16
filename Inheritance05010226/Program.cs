// See https://aka.ms/new-console-template for more information
using Inheritance05010226;

Console.WriteLine("Hello, World!");

//Animal a1 = new Animal("Name", 12);
Animal d1 = new Dog("Fido", 2, "Puddel", "Red");

Animal c1 = new Cat("Findus", 3, true, "Green");

d1.Speak();
c1.Speak();
Console.WriteLine(c1);

List<Animal> listeAfDyr = new List<Animal>();

listeAfDyr.Add(d1);//index 0
listeAfDyr.Add(c1);//index 1
listeAfDyr.Add(new Dog("Coco", 5, "Shiba", "Red"));//index 2

foreach (Animal a in listeAfDyr)
{
    a.Speak();
}

Dog d2 =  (Dog) listeAfDyr[2];


AnimalRepositoryList repo = new AnimalRepositoryList();
try
{
    repo.AddAnimal(d1);
    repo.AddAnimal(c1);
}
catch (AnimalAllReadyExistException aex)
{
    Console.WriteLine(aex.Message);
}
catch (ArgumentException auex)
{
    Console.WriteLine(auex.Message);
}
catch (Exception exp)
{
    Console.WriteLine(exp.Message);
}
finally
{
    Console.WriteLine("Denne blok kommer man i altid");
}

List<Animal> animalAgeToPrint = repo.FindAnimalsByAgeInterval(2, 3);
foreach(Animal a in animalAgeToPrint)
{
    Console.WriteLine(a.ToString());
}

Animal oldest = repo.GetOldestAnimal();
if (oldest != null)
{
    Console.WriteLine(oldest);
}



//Design sekvensdiagram
Animal foundAnimal = repo.GetAnimal("Fido");

