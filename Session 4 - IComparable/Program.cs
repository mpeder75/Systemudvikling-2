
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

var myCars = new List<Vehicle>();
myCars.Add(vehicle1);
myCars.Add(vehicle2);


myCars.Sort();

vehicle1.CompareTo(vehicle2);


// class Vehicle implementer IEquatable
public class Vehicle : IComparable<Vehicle>
{
    public string Color { get; set; }
    public int ID { get; set; }
    public string Name { get; set; }
    public int TirePressure { get; set; }
    public int Weight { get; set; }

    //CompareTo() fra IComparable - man udfylder SELV logik - returnere int
    public int CompareTo(Vehicle? other)
    {
        if (other == null)
        {
            return 1;
        } else
        {
            return Weight.CompareTo(other.Weight);
        }
    }
}
