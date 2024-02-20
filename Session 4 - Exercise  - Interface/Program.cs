// Person array initializeres
Person[] simpsons = new Person[]
{
    new Person (1, 50, "Homer", "Simpson"),
    new Person (2, 2, "Maggie", "Simpson"),
    new Person (3, 12, "Bart", "Simpson"),
    new Person (4, 11, "Lisa", "Simpson"),
    new Person (5, 50, "Marge", "Simpson"),
    new Person (6,60, "Moe", "Szyslak")
};

// sorter array efter alder
var orderedByAge = simpsons.OrderByDescending(person => person.Age);
Console.WriteLine();

// CompareTo
int homerVsMaggie = simpsons[0].CompareTo(simpsons[1]);
int homerVsMoe = simpsons[0].CompareTo(simpsons[5]);
int homerVsMarge = simpsons[4].CompareTo(simpsons[0]);

Console.WriteLine();

class Person : IComparable<Person>
{
    // prop har kun GET for at opnå encapsulation - settes i constructor
    public int Id { get; }
    public int Age { get; }
    public string FirstName { get; }
    public string LastName { get; }

    public Person(int id, int age, string firstname, string lastname)
    {
        this.Id = id;
        this.Age = age;
        this.FirstName = firstname;
        this.LastName = lastname;
    }

    public int CompareTo(Person? otherPerson)
    {
        if (otherPerson.Age == Age)
        {
            Console.WriteLine($"{otherPerson.ToString()} har samme alder som {this.ToString()}");
            return 0;
        }
        else if (otherPerson.Age < Age)
        {
            Console.WriteLine($"{otherPerson.ToString()} er yngre end {this.ToString()}");
            return 1;
        }
        else
        {
            Console.WriteLine($"{otherPerson.ToString()} er ældre end {this.ToString()}");
            return -1;
        }
        //return Age.CompareTo(otherPerson.Age);
    }
    public override string ToString()
    {
        return $"{FirstName}({Age})";
    }
}