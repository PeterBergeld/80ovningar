//Skriv en funktion som beräknar 
// vad du ska betala för en tank bensin. 
// Indata är antal liter, pris per liter och 
// eventuell rabatt i procent. 
// Utdata är priset som du ska betala

Console.WriteLine("Hur många liter");
decimal liter ; 
decimal.TryParse(Console.ReadLine(), out liter);
decimal prisPerLiter ;
decimal.TryParse(Console.ReadLine(), out prisPerLiter);
decimal rabbat;
decimal.TryParse(Console.ReadLine(), out rabbat);

decimal totalPris = liter*prisPerLiter;
decimal rabattBelopp = totalPris * (rabbat/100m);


decimal slutPris = totalPris - rabattBelopp;
Console.WriteLine($"Totalt pris före rabatt: {totalPris} kr");
Console.WriteLine($"Rabatt: {rabattBelopp:F2} kr");
Console.WriteLine($"Slutpris att betala: {slutPris:F2} kr");


