// Person array
Person[] simpsons = new Person[]
{
    new Person {Id = 1, Age = 50, FirstName = "Homer", LastName = "Simpson"},
    new Person {Id = 2, Age = 2, FirstName = "Maggie", LastName = "Simpson"},
    new Person {Id = 3, Age = 12, FirstName = "Bart", LastName = "Simpson"},
    new Person {Id = 4, Age = 11, FirstName = "Lisa", LastName = "Simpson"},
    new Person {Id = 5, Age = 50, FirstName = "Marge", LastName = "Simpson"},
    new Person {Id = 6, Age = 60,FirstName = "Moe", LastName = "Szyslak"}
};

// sorter array efter alder
var orderedByAge = simpsons.OrderByDescending(person => person.Age);

int homerVsMaggie = simpsons[0].CompareTo(simpsons[1]);
int homerVsMoe = simpsons[0].CompareTo(simpsons[5]);
int homerVsMarge = simpsons[4].CompareTo(simpsons[0]);

Console.WriteLine();

class Person : IComparable<Person>
{
    public int Id { get; set; }
    public int Age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int CompareTo(Person? other)
    {
        if (other.Age == Age)
        {
            Console.WriteLine($"{other.ToString()} har samme alder som {this.ToString()}");
            return 0;
        }
        else if (other.Age < Age)
        {
            Console.WriteLine($"{other.ToString()} er yngre end {this.ToString()}");
            return 1;
        }
        else
        {
            Console.WriteLine($"{other.ToString()} er ældre end {this.ToString()}");
            return -1;
        }
        //return Age.CompareTo(other.Age);
    }
    public override string ToString()
    {
        return $"{FirstName}({Age})";
    }
}