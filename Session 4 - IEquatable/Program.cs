
Vehicle vehicle1 = new Vehicle()
{
    ID = 1,
    Name = "BMW",
    Color = "grey",
    TirePressure = 64,
    Weight = 1970
};
Vehicle vehicle2 = new Vehicle()
{
    ID = 2,
    Name = "BMW",
    Color = "grey",
    TirePressure = 64,
    Weight = 1970
};

// Equals metode der er nedarvet fra IEquatable bruges til at sammenligne og vehicle1 og vehicle2
// har samme navn og tirepressure
bool isEqual = vehicle1.Equals(vehicle2);


/* 
    Nyttige metoder fra IEquatable: (kræver en List)
    • Contains()
    • IndexOf()
    • LastIndexOf()
    • Remove()
*/


// Contains()
var myCars = new List<Vehicle>();
myCars.Add(vehicle1);
myCars.Add(vehicle2);

// contains bruges til at undersøge om listen indeholder vehicle1 objektet
bool doesContain = myCars.Contains(vehicle1);



// class Vehicle implementer IEquatable
public class Vehicle : IEquatable<Vehicle>
{
    public string Color { get; set; }
    public int ID { get; set; }
    public string Name { get; set; }
    public int TirePressure { get; set; }
    public int Weight { get; set; }

    //Equals metode fra IEquatable - man udfylder SELV logik
    public bool Equals(Vehicle? other)
    {
        if (other == null)
        {
            return false;
        }
        else if (other.Name == Name && other.TirePressure == TirePressure)  // her sammenlignes KUN name og tirespressure
        {
            return true;
        }
        return false;
    }
}
