namespace algorithms_studies.Helpers;

public static class ArrayPrinter
{
    public static void PrintArray(this int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}