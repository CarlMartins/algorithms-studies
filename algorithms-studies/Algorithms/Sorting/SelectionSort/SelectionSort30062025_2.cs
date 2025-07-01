namespace algorithms_studies.Algorithms.Sorting.SelectionSort;

public static class SelectionSort30062025_2
{
    public static int[] Sort(int[] array)
    {
        for (var i = 0; i <= array.Length - 1; i++)
        {
            var smallestNumberIndex = i;

            for (var j = i + 1; j <= array.Length - 1; j++)
            {
                if (array[j] >= array[smallestNumberIndex])
                    continue;

                smallestNumberIndex = j;
            }

            if (smallestNumberIndex == i)
                continue;

            (array[i], array[smallestNumberIndex]) = (array[smallestNumberIndex], array[i]);
        }

        return array;
    }
}