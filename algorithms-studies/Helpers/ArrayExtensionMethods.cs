namespace algorithms_studies.Helpers;

public static class ArrayExtensionMethods
{
    public static void PrintArray(this int[] array)
    {
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }

    public static void PrintArray(this int[] array, string date)
    {
        Console.WriteLine($"[{string.Join(", ", array)}]    ({date})");
    }

    public static string GetFormatedArray(this int[] array)
    {
        return string.Join(", ", array);
    }
}