namespace algorithms_studies.Algorithms.Sorting.SelectionSort;

public static class SelectionSort_20250702
{
    public static int[] Sort(int[] array)
    {
        for (var i = 0; i <= array.Length - 1; i++)
        {
            var lowestValueIndex = i;

            for (var j = i + 1; j <= array.Length - 1; j++)
            {
                if (array[j] >= array[lowestValueIndex])
                    continue;

                lowestValueIndex = j;
            }

            if (i == lowestValueIndex)
                continue;

            (array[i], array[lowestValueIndex]) = (array[lowestValueIndex], array[i]);
        }

        return array;
    }
}