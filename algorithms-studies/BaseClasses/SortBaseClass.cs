namespace algorithms_studies.BaseClasses;

public abstract class SortBaseClass
{
    protected readonly int[] Array = [64, 34, 25, 12, 22, 90, 11, 12];
    protected SortBaseClass()
    { }

    protected SortBaseClass(int[] array)
    {
        Array = array;
    }
    
    protected void PrintHeader(string sortName)
    {
        Console.WriteLine($"\n____________{sortName}____________\n");
        PrintBaseArray();
    }

    private void PrintBaseArray()
    {
        Console.WriteLine($"[{Array.GetFormatedArray()}]    (Base array)");
        Console.WriteLine("-------------------------");
    }

    protected void PrintFooter()
    {
        Console.WriteLine($"____________________________________________________________");
    }
}