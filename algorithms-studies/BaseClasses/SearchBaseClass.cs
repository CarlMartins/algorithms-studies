namespace algorithms_studies.BaseClasses;

public class SearchBaseClass
{
    protected static int[] Array = [2, 6, 23, 45, 99, 150, 152];
    protected static int Target = 150;

    protected SearchBaseClass()
    { }

    protected SearchBaseClass(int[] array, int target)
    {
        Array = array;
        Target = target;
    }
    
    protected void PrintHeader(string searchName)
    {
        Console.WriteLine($"\n____________{searchName}____________\n");
        PrintBaseValues();
    }

    private void PrintBaseValues()
    {
        Console.WriteLine($"[{Array.GetFormatedArray()}]    (Base array)");
        Console.WriteLine($"{Target}    (Target value)");
        Console.WriteLine("-------------------------");
    }
    
    protected void PrintFooter()
    {
        Console.WriteLine($"____________________________________________________________");
    }

    protected void ValidateSortedArray(string sortName)
    {
        var list = Array.ToList();
        list.Sort();
        
        var isOrdered = Array.SequenceEqual(list);

        if (!isOrdered)
            throw new Exception($"For {sortName}, the array needs to be ordered!");
    }
}