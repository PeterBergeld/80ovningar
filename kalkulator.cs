//Gör en enkel kalkulator


double Add(double tal1, double tal2)
{
    return tal1 + tal2;
}
static double subtract(double tal1, double tal2)
{
    return tal1 - tal2;
    
}

static double multiply(double tal1, double tal2)
{
    return tal1 * tal2;
    
}

static double divison(double tal1, double tal2)
{
    return tal1 / tal2;
    
}


while (true)
{
    Console.WriteLine("Tal 1;");
    double tal1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Tal 2;");
    double tal2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("\n"); //Just one row below

Console.WriteLine("Välj operation (+, subtraction, *, /) eller skriv exit:");
string choice = Console.ReadLine();
if (choice == "exit")
    {
        break;
    }
if (choice == "+")
{
    Console.WriteLine(Add(tal1 , tal2));
}
else if (choice == "subtraction")
{
    Console.WriteLine(subtract(tal1,tal2));
}
else if (choice == "*") 
{
    Console.WriteLine(multiply (tal1,tal2));
}

else if (choice == "/") 
{
    Console.WriteLine(divison(tal1,tal2));
}
}
