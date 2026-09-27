// ska räkna ut antal timmar och konvertera det till 
//min resp. sek. 

Console.WriteLine("Hur många timmar vill du spela?");
double timmar ;
double.TryParse(Console.ReadLine(), out timmar);

double min = 60 * timmar;
double sek = 3600 * timmar;

Console.WriteLine($"Sekunder: {sek}, Minuter: {min} om du har så många timmar ");