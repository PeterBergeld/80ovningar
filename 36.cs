// skriv en funktion som räknar ut hur mycket man har på banken 
// under vart och ett av de följande 10 åren om man 
// sätter in 1000 kr. Räntan ska läsas in och är densamma för alla åren.

static void Bank()
{
    System.Console.Write("Ange räntan i procent: ");
    double ränta = double.Parse(Console.ReadLine());

    double pengar = 1000;

    for (int år = 1; år <= 10; år++)
{
    pengar += pengar * ränta / 100;

    System.Console.WriteLine($"År {år}: {pengar:F2} kr");
}
}Bank();