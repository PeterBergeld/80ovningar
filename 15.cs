// Skriv en funktion som läser in två tal 
// och avgör och skriver ut om det 
// första talet är jämnt delbart med det andra talet.


void ÄrDelbart(int tal1, int tal2) //Function
{

    if (tal1 % tal2 == 0)
{
    Console.WriteLine("Tal1 är jämnt delbart med tal2");
}
}
 

int tal1 = int.Parse(Console.ReadLine()!);
int tal2 = int.Parse(Console.ReadLine()!);

ÄrDelbart(tal1, tal2);