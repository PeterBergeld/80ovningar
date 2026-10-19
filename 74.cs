//Create a function that finds and prints the 
// largest and smallest values in an array.

       
public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.FindMinMax();
    }
     public void FindMinMax()
    {
        int [] numbers = {12,5,27,3,19};
        int max = numbers[0];
        int min = numbers[0];

    foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }
            System.Console.WriteLine($"Largest: {max}");
            System.Console.WriteLine($"Smallest: {min}");
    }
}