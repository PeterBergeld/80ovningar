static void Vadärtalet()
{
    System.Console.WriteLine("Vad är talet?");
    Console.ReadLine();
    string? input = Console.ReadLine();
    int.TryParse(input, out int tal);

    if (tal >= 0 && tal <= 9 && tal != 5) 
        {
        Console.Write("Du skrev rätt tal");
        }
        else if (tal == 5)
        {
           System.Console.WriteLine("Du har valt fem och det går inte"); 
        }
    else
    {
        System.Console.WriteLine("Talet måste vara mellan 0 och 9");
    }
    }


Vadärtalet();



