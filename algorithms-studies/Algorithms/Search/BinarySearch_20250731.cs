namespace algorithms_studies.Algorithms.Search;

public static class BinarySearch_20250731
{
    public static int BinarySearch(int[] array, int target, int? low = null, int? high = null)
    {
        var lowValue = low ?? 0;
        var highValue = high ?? array.Length - 1;

        if (lowValue > highValue)
            return -1;

        var midPoint = lowValue + (highValue - lowValue) / 2;

        if (array[midPoint] == target)
            return midPoint;

        if (target < array[midPoint])
            return BinarySearch(array, target, lowValue, midPoint - 1);

        return BinarySearch(array, target, midPoint + 1, highValue);
    }
}