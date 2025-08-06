using algorithms_studies.BaseClasses;

namespace algorithms_studies.Algorithms.Sorting.SelectionSort;

public class SelectionSort : SortBaseClass
{
    private const string SortName = "SELECTION SORT";

    public SelectionSort()
    { }

    public SelectionSort(int[] array) : base(array)
    { }
    
    public void PrintSelectionSort()
    {
        PrintHeader(SortName);

        SelectionSort_20250630.Sort(Array.ToArray()).PrintArray("2025-06-30");
        SelectionSort_20250630_2.Sort(Array.ToArray()).PrintArray("2025-06-30");
        SelectionSort_20250702.Sort(Array.ToArray()).PrintArray("2025-07-02");
        SelectionSort_20250707.Sort(Array.ToArray()).PrintArray("2025-07-07");
        SelectionSort_20250710.Sort(Array.ToArray()).PrintArray("2025-07-10");
        SelectionSort_20250716.Sort(Array.ToArray()).PrintArray("2025-07-16");
        SelectionSort_20250717.Sort(Array.ToArray()).PrintArray("2025-07-17");
        SelectionSort_20250718.Sort(Array.ToArray()).PrintArray("2025-07-18");
        SelectionSort_20250719.Sort(Array.ToArray()).PrintArray("2025-07-19");
        SelectionSort_20250720.Sort(Array.ToArray()).PrintArray("2025-07-20");
        SelectionSort_20250721.Sort(Array.ToArray()).PrintArray("2025-07-21");
        SelectionSort_20250722.Sort(Array.ToArray()).PrintArray("2025-07-22");
        SelectionSort_20250723.Sort(Array.ToArray()).PrintArray("2025-07-23");
        SelectionSort_20250724.Sort(Array.ToArray()).PrintArray("2025-07-24");
        SelectionSort_20250728.Sort(Array.ToArray()).PrintArray("2025-07-28");
        SelectionSort_20250729.Sort(Array.ToArray()).PrintArray("2025-07-29");
        SelectionSort_20250804.Sort(Array.ToArray()).PrintArray("2025-08-04");
        
        PrintFooter();
    }
}