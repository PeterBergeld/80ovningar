// Konstruera en funktion där värden på variablerna X och Y läses in. 
// Tilldela variabel A värdet 2 om X är större än 5 + Y, 
// annars tilldela A värdet 5. Skriv ut variabeln A.

Console.WriteLine("kjadasdadd");
void BestämA()
{
    
double X = double.Parse(Console.ReadLine()!);
double Y = double.Parse(Console.ReadLine()!);

double A;

if (X > 5 + Y) 
{
    A = 2;
}
else
{
    A = 5;
}

Console.WriteLine(A); 

}

BestämA();

