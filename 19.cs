// En anställd som har timlön får, när arbetstiden överstiger 40 tim en vecka, 
// övertidsbetalning för tiden utöver 40 tim med 1½ tim. 
// Skriv en funktion som läser in en anställds timlön och en veckas arbetstid. 
// Den totala veckolönen ska beräknas och skrivas ut.


Console.WriteLine("Hur många timmar har duu jobbat");

static double Veckolön(double timlön, double arbetstid)


{
    
    double fullön = timlön * 40; 
    

if (arbetstid > 40)
{
      double övertid = arbetstid - 40;
     double övertidsLön = övertid * timlön * 1.5;
  double totallön = fullön + övertidsLön;
  
  return totallön;
}

    return fullön;
}

double arbetstid = double.Parse(Console.ReadLine()!);
double timlön = double.Parse(Console.ReadLine()!);

Console.WriteLine(Veckolön(timlön, arbetstid));


