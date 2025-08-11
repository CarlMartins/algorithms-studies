namespace algorithms_studies.Algorithms.Search.BinarySearch;

public static class BinarySearch_20250811
{
    public static int BinarySearch(int[] array, int targetValue, int? min = null, int? max = null)
    {
        if (array.Length == 0)
            return -1;

        if (array.Length == 1)
            return 1;

        var minValue = min ?? 0;
        var maxValue = max ?? array.Length - 1;
        
        if (min > max)
            return -1;
        
        var midIndex = minValue + (maxValue - minValue) / 2;

        if (array[midIndex] == targetValue)
            return midIndex;

        if (array[midIndex] > targetValue)
            return BinarySearch(array, targetValue, minValue, midIndex - 1);

        return BinarySearch(array, targetValue, midIndex + 1, maxValue);
    }
}