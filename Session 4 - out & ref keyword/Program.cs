
double s = 0;
double g = 0;

double t1 = 5;
double t2 = 2;

BeregnSum(t1, t2, out s, out g);

void BeregnSum(double x, double y, out double ss, out double gg)
{
    ss = x + y;  // værdi på adressen i ss = 5 + 2
    gg = ss/2;   // værdien på adressen i gg = 7 / 2
}


