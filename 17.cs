//Skriv en funktion som läser in två 
// tal och dividerar det första talet med det andra talet. 
// Om det andra talet (nämnaren) är 
// 0 ska ett felmeddelande ges, 
// annars ska kvoten skrivas ut.


double Dividera( double tal1, double tal2)

{
    if (tal2 == 0) 
    
{

    Console.WriteLine("svaret blir 0 och fel");
    return 0;
}
else
{
    double kvoten = tal1 / tal2;
    return kvoten;
    
}
}
double tal1 = double.Parse(Console.ReadLine()!);
double tal2 = double.Parse(Console.ReadLine()!);
Console.WriteLine(Dividera(tal1, tal2));