//IDEA: Standard ToString()
/*
int age = 23;

Console.WriteLine(age.ToString());
*/

Person poul = new Person("Poul", 50);

Console.WriteLine(poul);
Console.WriteLine(poul.Age);
Console.WriteLine(poul.Name);

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    // override ToString() - tillader at man kan custom made hvad der printes når ToString kaldes
    public override string ToString()
    {
        return $"Your name is {Name} and your age is {Age}";
    }
}