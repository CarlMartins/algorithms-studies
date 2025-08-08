namespace algorithms_studies.BaseClasses;

public abstract class SortBase : PrintBase
{
    protected readonly int[] Array = [64, 34, 25, 12, 22, 90, 11, 12];
    protected SortBase(string name) : base(name)
    { }

    protected SortBase(int[] array)
    {
        Array = array;
    }
    
    protected void PrintHeader()
    {
        PrintTitle();
        PrintBaseArray(Array);
        PrintDivider();
    }
}