using System.Net.NetworkInformation;

double pi = 3.14;
double radie;
double.TryParse(Console.ReadLine(),out radie);
double diameter = radie*2; 
double omkrets = 2*pi*radie;
double area = pi*radie*radie ;


Console.WriteLine(diameter);
Console.WriteLine(omkrets);
Console.WriteLine(area);