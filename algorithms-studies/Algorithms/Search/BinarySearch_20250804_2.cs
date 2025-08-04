namespace algorithms_studies.Algorithms.Search;

public static class BinarySearch_20250804_2
{
    public static int BinarySearch(int[] sortedArray, int targetValue, int? low = null, int? high = null)
    {
        var lowValue = low ?? 0;
        var highValue = high ?? sortedArray.Length - 1;

        if (lowValue > highValue)
            return -1;

        var midIndex = lowValue + (highValue - lowValue) / 2;
        var midIndexValue = sortedArray[midIndex];

        if (midIndexValue == targetValue)
            return midIndex;

        if (midIndexValue < targetValue)
            return BinarySearch(sortedArray, targetValue, midIndex + 1, highValue);

        return BinarySearch(sortedArray, targetValue, lowValue, highValue - 1);
    }
}