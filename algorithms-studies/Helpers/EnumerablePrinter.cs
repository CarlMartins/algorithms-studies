namespace algorithms_studies.Helpers;

public static class EnumerablePrinter
{
    public static void PrintEnumerable<T>(this IEnumerable<T> enumerable)
    {
        Console.WriteLine(string.Join(", ", enumerable));
    }
}