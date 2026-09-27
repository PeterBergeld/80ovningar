// Skriv en funktion som läser in ett tal. 
// Om talet är mellan 0 och 9 ska kvadraten på talet skrivas ut. Annars ska lämpligt 
// felmeddelande ges.


using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata;
static string Läsinput ()

{ 

Console.WriteLine ("Vilket tal väljer du ?");
string input = Console.ReadLine();
    return input;
    
}
string input = Läsinput();

 if (double.TryParse(input, out double tal))

{
    if (tal >= 0  && tal <= 9) 
{

    Console.WriteLine($"Du valde tal{tal}!");

        double kvadraten = tal * tal;

    Console.WriteLine(kvadraten);
}

else 
{
    Console.WriteLine("Talet måste vara meallan 0 och 9");
}
}
else
{
    Console.WriteLine("Du skrev inte ett tal! din fuckface:D");
}


// if tal = tal 0 > || tal <9;
// {
//     Console.tryParse(kvadrat);
// }
// else