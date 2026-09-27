Console.WriteLine("Vilket tal är störst");

double StörstaTalet(double tal1, double tal2)
{
    if (tal1 > tal2)
    {
        return tal1;
    }

    return tal2;
}


double störst = StörstaTalet(5, 11);
Console.WriteLine(störst);

