using algorithms_studies.BaseClasses;

namespace algorithms_studies.Algorithms.Sorting.InsertionSort;

public class InsertionSort : SortBaseClass
{
    private readonly int[] _array = [64, 34, 25, 12, 22, 90, 11, 12];
    private const string SortName = "INSERTION SORT";

    public void PrintInsertionSort()
    {
        PrintHeader(SortName);

        InsertionSort20250710.Sort(_array.ToArray()).PrintArray("2025-07-10");
        InsertionSort20250717.Sort(_array.ToArray()).PrintArray("2025-07-17");
        InsertionSort20250717_2.Sort(_array.ToArray()).PrintArray("2025-07-17");
        InsertionSort20250717_3.Sort(_array.ToArray()).PrintArray("2025-07-17");
        InsertionSort20250717_4.Sort(_array.ToArray()).PrintArray("2025-07-17");
        InsertionSort20250717_5.Sort(_array.ToArray()).PrintArray("2025-07-17");
        InsertionSort20250717_6.Sort(_array.ToArray()).PrintArray("2025-07-17");
        InsertionSort20250718.Sort(_array.ToArray()).PrintArray("2025-07-18");
        InsertionSort20250719.Sort(_array.ToArray()).PrintArray("2025-07-19");
        InsertionSort20250720.Sort(_array.ToArray()).PrintArray("2025-07-20");
        InsertionSort20250721.Sort(_array.ToArray()).PrintArray("2025-07-21");
        InsertionSort20250722.Sort(_array.ToArray()).PrintArray("2025-07-22");
        InsertionSort20250723.Sort(_array.ToArray()).PrintArray("2025-07-23");
        InsertionSort20250724.Sort(_array.ToArray()).PrintArray("2025-07-24");
        InsertionSort20250728.Sort(_array.ToArray()).PrintArray("2025-07-28");
        InsertionSort20250729.Sort(_array.ToArray()).PrintArray("2025-07-29");
        InsertionSort20250804.Sort(_array.ToArray()).PrintArray("2025-08-04");
        
        PrintFooter();
    }
}