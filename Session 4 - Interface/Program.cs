// List af datatypen IAnimal (interface)
List<IAnimal> animals = new List<IAnimal>();

// instanser af dog & cat oprettes
Dog dog = new Dog();
Cat cat = new Cat();

// tilføjes til listen
animals.Add(dog);
animals.Add(cat);

// nu da alle instancer implementer inferfacet IAnimal, har de ALLE
// * int Legs property
// * metoden MakeSound()
// Nu looper vi igennem collection, og printer deres MakeSound() metoder ud
foreach (IAnimal animal in animals)
{
    animal.MakeSound();
}



public interface IAnimal
{
    int Legs { get; set; }
    void MakeSound();
}

// class Dog implementer interface IAnimal, og skal implemente dente attributter og methods
public class Dog : IAnimal
{
    public int Legs { get; set; }

    public void MakeSound()
    {
        Console.WriteLine("Woof woof");
    }
}

// class Dog implementer interface IAnimal, og skal implemente dente attributter og methods
public class Cat : IAnimal
{
    public int Legs { get; set; }

    public void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}