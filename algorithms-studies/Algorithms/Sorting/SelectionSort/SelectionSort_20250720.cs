namespace algorithms_studies.Algorithms.Sorting.SelectionSort;

public static class SelectionSort_20250720
{
    public static int[] Sort(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var lowestNumberIndex = i;

            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[j] >= array[lowestNumberIndex])
                    continue;

                lowestNumberIndex = j;
            }

            if (lowestNumberIndex == i)
                continue;
            
            (array[i], array[lowestNumberIndex]) = (array[lowestNumberIndex], array[i]);
        }

        return array;
    }
}