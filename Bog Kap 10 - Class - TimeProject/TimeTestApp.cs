using Bog_Kap_10___Class___TimeProject;
using System.Xml;

// Creates & initialize a Time1 object
Time1 myTime = new Time1();

Console.WriteLine($"Initial universal time is: {myTime.ToUniversalString()}");

Console.WriteLine($"Initial standard time is: {myTime.ToString()}\n");


// change time and output updated time
myTime.SetTime(13, 27, 6);

// output new time
Console.WriteLine($"Updated time in universal time is: {myTime.ToUniversalString()}");
Console.WriteLine($"Updated time in standard time is: {myTime.ToUniversalString()}");

