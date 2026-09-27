//Skriv en funktion som läser in ett tal och skriver ut om det 
//är jämnt. (Använd modulooperatorn)


bool ÄrJämnt(int tal)
{
    return tal % 2 == 0;
}

int tal = int.Parse(Console.ReadLine()!);

if (ÄrJämnt(tal))
{
    Console.WriteLine("talet är jämnt");
}

if (Ärojämnt (tal));