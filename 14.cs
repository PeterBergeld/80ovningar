// Skriv en funktion som läser in ett tal och skriver 
// ut om det är udda eller jämnt.

void ÄrJämnt(int tal)
{
    if (tal % 2 == 0)
    {
        Console.WriteLine("Talet är jämnt");
    }
    else
    {
        Console.WriteLine("Talet är udda");
    }
}
int tal = int.Parse(Console.ReadLine()!);

ÄrJämnt(tal);