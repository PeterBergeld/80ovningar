//Läs in två tal. Testa om det första talet är mer 
// än dubbelt så stort som det andra talet. 
// I så fall ska meddelandet “För stort“ skrivas ut.


double tal1;
double tal2;

double.TryParse(Console.ReadLine(),out tal1);
double.TryParse(Console.ReadLine(),out tal2);

if (tal1 > tal2 * 2) 
{
    Console.WriteLine("tal1 är mer än dubbelt så stort");
}

Console.WriteLine("För litet tal");