using algorithms_studies.Exceptions;

namespace algorithms_studies.BaseClasses;

public class SearchBase : PrintBase
{
    protected static int[] Array = [2, 6, 23, 45, 99, 150, 152];
    protected static int Target = 150;

    protected SearchBase(string searchName) : base(searchName)
    { }

    protected SearchBase(int[] array, int target)
    {
        Array = array;
        Target = target;
    }
    
    protected void PrintHeader(string searchName)
    {
        PrintTitle();
        PrintBaseValues();
        PrintDivider();
    }

    private void PrintBaseValues()
    {
        PrintBaseArray(Array);
        PrintTargetValue(Target);
    }

    protected void ValidateSortedArray(string sortName)
    {
        var list = Array.ToList();
        list.Sort();
        
        var isOrdered = Array.SequenceEqual(list);

        if (!isOrdered)
            throw new NotOrderedArrayException($"For {sortName}, the array needs to be ordered!");
    }
}