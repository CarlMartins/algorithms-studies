using algorithms_studies.BaseClasses;

namespace algorithms_studies.Algorithms.Sorting.InsertionSort;

public class InsertionSort : SortBaseClass
{
    private const string SortName = "INSERTION SORT";

    public InsertionSort() : base()
    { }

    public InsertionSort(int[] array) : base(array)
    { }
    
    public void PrintInsertionSort()
    {
        PrintHeader(SortName);

        InsertionSort20250710.Sort(Array.ToArray()).PrintArray("2025-07-10");
        InsertionSort20250717.Sort(Array.ToArray()).PrintArray("2025-07-17");
        InsertionSort20250717_2.Sort(Array.ToArray()).PrintArray("2025-07-17");
        InsertionSort20250717_3.Sort(Array.ToArray()).PrintArray("2025-07-17");
        InsertionSort20250717_4.Sort(Array.ToArray()).PrintArray("2025-07-17");
        InsertionSort20250717_5.Sort(Array.ToArray()).PrintArray("2025-07-17");
        InsertionSort20250717_6.Sort(Array.ToArray()).PrintArray("2025-07-17");
        InsertionSort20250718.Sort(Array.ToArray()).PrintArray("2025-07-18");
        InsertionSort20250719.Sort(Array.ToArray()).PrintArray("2025-07-19");
        InsertionSort20250720.Sort(Array.ToArray()).PrintArray("2025-07-20");
        InsertionSort20250721.Sort(Array.ToArray()).PrintArray("2025-07-21");
        InsertionSort20250722.Sort(Array.ToArray()).PrintArray("2025-07-22");
        InsertionSort20250723.Sort(Array.ToArray()).PrintArray("2025-07-23");
        InsertionSort20250724.Sort(Array.ToArray()).PrintArray("2025-07-24");
        InsertionSort20250728.Sort(Array.ToArray()).PrintArray("2025-07-28");
        InsertionSort20250729.Sort(Array.ToArray()).PrintArray("2025-07-29");
        InsertionSort20250804.Sort(Array.ToArray()).PrintArray("2025-08-04");

        PrintFooter();
    }
}