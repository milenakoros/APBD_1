//używamy PascalCase

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello");
        
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello");


        Console.WriteLine("Średnia dla tablicy {1,2,3,4,2,3} to: " + CalculateAverage(new []{1,2,3,4,2,3}));
        //String a string
        
        
    }

    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            Console.WriteLine("Pusta tablica lub null");
            return 0;
        }

        double sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Length;
    }
}
