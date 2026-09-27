double celcius(double fahrenheit) // double Finction name(double input)
{
    return (fahrenheit - 32) * 5/9; //return something
}

Console.WriteLine("Hur många fahrenheit");


double fahrenheit;
double.TryParse(Console.ReadLine(), out fahrenheit);

double celcius = celcius(fahrenheit);
Console.WriteLine(celcius);