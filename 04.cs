Console.WriteLine("Skriv ett nummer");

for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Skriv ett nummer");
    double.TryParse(Console.ReadLine(), out tal1); //testade att göra en loop men 
    //behöver göra det för samtliga 
}

double tal1;
double tal2;
double tal3;



double.TryParse(Console.ReadLine(), out tal1);
double.TryParse(Console.ReadLine(), out tal2);
double.TryParse(Console.ReadLine(), out tal3);
double summan = tal1 + tal2 + tal3;

double medelvärde = summan / 3;

Console.WriteLine(summan);
Console.WriteLine(medelvärde);