namespace algorithms_studies.Algorithms.Sorting.SelectionSort;

public static class SelectionSort20250710
{
    public static int[] Sort(int[] array)
    {
        for (var i = 0; i <= array.Length - 1; i++)
        {
            var lowestNumberIndex = i;

            for (int j = i; j < array.Length - 1; j++)
            {
                if (array[j] >= array[lowestNumberIndex])
                    continue;

                lowestNumberIndex = i;
            }

            if (lowestNumberIndex == i)
                continue;

            (array[i], array[lowestNumberIndex]) = (array[lowestNumberIndex], array[i]);
        }

        return array;
    }
}