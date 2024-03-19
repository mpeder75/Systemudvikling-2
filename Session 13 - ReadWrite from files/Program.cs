

//! -------- Read from txt file --------

// Eksempel 1
/*string path = @"C:\DatabaseFile.txt";

string text = File.ReadAllText(path);

Console.WriteLine($"Textfile contains following text{new string('_', 30)}");

Console.ReadKey();*/

// Eksempel 2
/*string path = @"C:\DatabaseFile.txt";

string read = File.ReadAllText(path);

string[] lines = File.ReadAllLines(path);

// printe fra txt fil

Console.WriteLine($"Reading file:\n{new string('_', 34)}\n");

foreach(string line in lines)
{
    Console.WriteLine(line); // hver linje i txtfil printes ud
}*/


//! -------- Write to Txt file --------

string path = @"C:\DatabaseFile.txt";

string[] stringToAdd = { "first line", "second line", "third line" };

File.WriteAllLines(path, stringToAdd);