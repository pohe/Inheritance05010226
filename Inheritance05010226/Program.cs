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
