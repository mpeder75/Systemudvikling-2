//! Delegates opgave
// Indsæt et 3 parameter som delegate, så der kan beregnes flere type a areal


double circleArea = BeregnAreal(-1, 1, Beregninger.CalculateCircleArea);
Print("Circle", circleArea);

double elipseArea = BeregnAreal(-1, 1, Beregninger.CalculateElipseArea);
Print("Elipse", elipseArea);

double squareArea = BeregnAreal(0, 2, Beregninger.CalculateSquare);
Print("Square", squareArea);





static double BeregnAreal(double a, double b, MyDelegate myDelegate)
{
    double areal = 0;

    for (double x = a; x <= b; x = x + 0.0001)
    {
        areal = areal + myDelegate(x) * 0.0001;
    }
    return areal;
}


// print metode
void Print(string functionName, double area)
{
    Console.WriteLine($"Arealet af {functionName} er= {area}");
}




// class der indeholder logik til ekstra beregninger
class Beregninger
{
    public static double CalculateCircleArea(double x)
    {
        double radius = 1.0;
        double y = Math.Sqrt(radius * radius - x * x);
        return y;
    }

    public static double CalculateElipseArea(double x)
    {
        double semiMajorAxis = 1.0;
        double semiMinorAxis = 0.5;

        double y = semiMinorAxis * Math.Sqrt(1 - (x * x) / (semiMajorAxis * semiMajorAxis));
        return y;
    }

    public static double CalculateSquare(double x)
    {
        double y = x * x;
        return y;
    }
}


// delegate
delegate double MyDelegate(double x);




