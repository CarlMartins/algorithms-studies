namespace algorithms_studies.Helpers;

public static class IntegerPrinter
{
    public static void PrintInteger(this int number)
    {
        Console.WriteLine(number);
    }

    public static void PrintInteger(this int number, string date)
    {
        Console.WriteLine($"{number}    ({date})");
    }
}