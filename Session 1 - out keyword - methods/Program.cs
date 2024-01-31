
double mySum;
double mySnit;

BeregnSumSnit(2.4, 3.3, out mySum, out mySnit);

Console.WriteLine(mySum);
Console.WriteLine(mySnit);



// metode der returnere 2 variabler, sum & snit
static void BeregnSumSnit(double a, double b, out double sum, out double snit)
{
    sum = a + b;
    snit = sum / 2;
}



