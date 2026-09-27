using System.ComponentModel;
using System.Numerics;

double VadSkaBetala(double antal, double prisPerEnhet)
{
    double totalPris = antal*prisPerEnhet;
    if (totalPris >= 1000) 
{
    Console.WriteLine("Du har handlat för mer än 1000kr");
    double rabbat = totalPris * 0.1;
    double slutPris = totalPris - rabbat;
    return slutPris;
    
}

else
{
    Console.WriteLine("Du ska betala fulltpris");
    return totalPris;
}
}

double antal = double.Parse(Console.ReadLine()!);
double prisPerEnhet = double.Parse(Console.ReadLine()!);

Console.WriteLine(VadSkaBetala(antal, prisPerEnhet));