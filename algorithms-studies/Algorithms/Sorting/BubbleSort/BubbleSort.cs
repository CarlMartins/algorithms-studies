using algorithms_studies.BaseClasses;

namespace algorithms_studies.Algorithms.Sorting.BubbleSort;

public class BubbleSort : SortBase
{
    private const string SortName = "BUBBLE SORT";
    
    public BubbleSort() : base(SortName)
    { }
    
    public BubbleSort(int[] array) : base(array)
    { }
    
    public void PrintBubbleSort()
    {
        PrintHeader();
        
        BubbleSort_20250625.Sort(Array.ToArray()).PrintArray("2025-06-25");
        BubbleSort_20250626.Sort(Array.ToArray()).PrintArray("2025-06-26");
        BubbleSort_20250630.Sort(Array.ToArray()).PrintArray("2025-06-30");
        BubbleSort_20250702.Sort(Array.ToArray()).PrintArray("2025-07-02");
        BubbleSort_20250707.Sort(Array.ToArray()).PrintArray("2025-07-07");
        BubbleSort_20250710.Sort(Array.ToArray()).PrintArray("2025-07-10");
        BubbleSort_20250716.Sort(Array.ToArray()).PrintArray("2025-07-16");
        BubbleSort_20250717.Sort(Array.ToArray()).PrintArray("2025-07-17");
        BubbleSort_20250718.Sort(Array.ToArray()).PrintArray("2025-07-18");
        BubbleSort_20250719.Sort(Array.ToArray()).PrintArray("2025-07-19");
        BubbleSort_20250720.Sort(Array.ToArray()).PrintArray("2025-07-20");
        BubbleSort_20250721.Sort(Array.ToArray()).PrintArray("2025-07-21");
        BubbleSort_20250721.Sort(Array.ToArray()).PrintArray("2025-07-21");
        BubbleSort_20250722.Sort(Array.ToArray()).PrintArray("2025-07-22");
        BubbleSort_20250723.Sort(Array.ToArray()).PrintArray("2025-07-23");
        BubbleSort_20250724.Sort(Array.ToArray()).PrintArray("2025-07-24");
        BubbleSort_20250728.Sort(Array.ToArray()).PrintArray("2025-07-28");
        BubbleSort_20250729.Sort(Array.ToArray()).PrintArray("2025-07-29");
        BubbleSort_20250804.Sort(Array.ToArray()).PrintArray("2025-08-04");
        BubbleSort_20250807.Sort(Array.ToArray()).PrintArray("2025-08-07");

        PrintFooter();
    }
}