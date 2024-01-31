
int oneToReturn, twoToReturn, fiveToReturn, tenToReturn, twentyToReturn;

Calc(100, 200, out oneToReturn, out twoToReturn, out fiveToReturn, out tenToReturn, out twentyToReturn);

Console.WriteLine($"20 to return: {twentyToReturn}");
Console.WriteLine($"10 to return: {tenToReturn}");
Console.WriteLine($"5 to return: {fiveToReturn}");
Console.WriteLine($"2 to return: {twoToReturn}");
Console.WriteLine($"1 to return: {oneToReturn}");


static void Calc(int price, int payment, out int oneToReturn, out int twoToReturn, out int fiveToReturn, out int tenToReturn, out int twentyToReturn)
{   
    int change = payment - price;           // returbeløb
     
    twentyToReturn = change / 20;           // hvor mange 20'ere skal retur
    int remainingChange = change % 20;      // returbeløb EFTER division med 20 assignes      

    tenToReturn = remainingChange / 10;     // hvor mange 10'ere skal retur. remainingChange bruges fra før
    remainingChange %= 10;                  // remainingChange opdateres

    fiveToReturn = remainingChange / 5;
    remainingChange %= 5;

    twoToReturn = remainingChange / 2;
    remainingChange %= 2;

    oneToReturn = remainingChange;
}