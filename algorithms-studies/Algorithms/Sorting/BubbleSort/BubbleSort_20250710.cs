namespace algorithms_studies.Algorithms.Sorting.BubbleSort;

public static class BubbleSort_20250710
{
    public static int[] Sort(int[] array)
    {
        for (var i = array.Length - 1; i > 0; i--)
        {
            var hasAnyChange = false;

            for (var j = 0; j < i; j++)
            {
                if (array[j] <= array[j + 1])
                    continue;

                (array[j], array[j + 1]) = (array[j + 1], array[j]);
                hasAnyChange = true;
            }

            if (!hasAnyChange)
                break;
        }

        return array;
    }
}