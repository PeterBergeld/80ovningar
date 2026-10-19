static void Medelvärdet()
{
    int summa = 0;
    int antal = 0;
    int tal = 0;


    while (tal != 9999)
    {
        System.Console.Write("Skriv ett tal (9999 för att för att räkna ut): ");
        tal = int.Parse(Console.ReadLine()); // HÖGER --> VÄNSTER!!

        if (tal != 9999)
        {
            summa += tal;
            antal++;
        }
    }

    if (tal == 0)
    {
        System.Console.WriteLine("Inga tal angavs.");

    }
    else
    {
        double medelvärde = (double)summa / antal;
        System.Console.WriteLine($"Medelvärde: {medelvärde:F2}");
    }
}

Medelvärdet();


// Läs in ett antal tal. 9999 ska vara stoppvärde. Beräkna och skriv ut 
// medelvärdet av de inlästa talen. Tänk på vad som händer 
// om det första inlästa talet är stoppvärdet.