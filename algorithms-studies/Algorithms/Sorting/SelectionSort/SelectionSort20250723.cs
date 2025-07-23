namespace algorithms_studies.Algorithms.Sorting.SelectionSort;

public static class SelectionSort20250723
{
    public static int[] Sort(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var lowestValueIndex = i;

            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[lowestValueIndex] <= array[j])
                    continue;

                lowestValueIndex = j;
            }

            if (lowestValueIndex == i)
                continue;

            (array[i], array[lowestValueIndex]) = (array[lowestValueIndex], array[i]);
        }

        return array;
    }
}