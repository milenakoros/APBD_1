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
        
        Console.WriteLine("Max wartosc dla tablicy {1,2,3,4,2,3} to: " + Max(new []{1,2,3,4,2,3}));

    }

    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            Console.WriteLine("Array cannot be null or empty");
            return 0;
        }

        double sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return sum / numbers.Length;
    }

    public static int Max(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            Console.WriteLine("Array cannot be null or empty");
            return 0;
        }

        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }

        return max;
    }
}
