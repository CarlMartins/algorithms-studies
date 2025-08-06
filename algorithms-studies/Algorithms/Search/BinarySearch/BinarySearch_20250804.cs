namespace algorithms_studies.Algorithms.Search.BinarySearch;

public static class BinarySearch_20250804
{
    public static int BinarySearch(int[] array, int valueToFind, int? low = null, int? high = null)
    {
        var lowValue = low ?? 0;
        var highValue = high ?? array.Length - 1;

        if (lowValue > highValue)
            return -1;

        var mid = lowValue + (highValue - lowValue) / 2;

        if (array[mid] == valueToFind)
            return mid;

        if (array[mid] > valueToFind)
            return BinarySearch(array, valueToFind, lowValue, mid - 1);

        return BinarySearch(array, valueToFind, mid + 1, highValue);
    }
}