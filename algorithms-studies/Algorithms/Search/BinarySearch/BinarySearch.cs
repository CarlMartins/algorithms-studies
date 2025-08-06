using algorithms_studies.BaseClasses;

namespace algorithms_studies.Algorithms.Search.BinarySearch;

public class BinarySearch : SearchBaseClass
{
    private const string SearchName = "BINARY SEARCH";
    
    public BinarySearch() : base()
    { }

    public BinarySearch(int[] array, int target) : base(array, target)
    { }
    
    public void PrintBinarySearches()
    {
        ValidateSortedArray(SearchName);
        PrintHeader(SearchName);
        
        BinarySearch_20250729.BinarySearch(Array, Target).PrintInteger("2025-07-29");
        BinarySearch_20250731.BinarySearch(Array, Target).PrintInteger("2025-07-31");
        BinarySearch_20250804.BinarySearch(Array, Target).PrintInteger("2025-08-04");
        BinarySearch_20250804_2.BinarySearch(Array, Target).PrintInteger("2025-08-04");
        
        PrintFooter();
    }
}