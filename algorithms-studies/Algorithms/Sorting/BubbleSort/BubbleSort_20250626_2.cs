namespace algorithms_studies.Algorithms.Sorting.BubbleSort;

public static class BubbleSort_20250626_2
{
    public static int[] Sort(int[] array)
    {
        for (var i = array.Length - 1; i > 0; i--)
        {
            var anyChanges = false;

            for (var j = 0; j < i; j++)
            {
                if (array[j] <= array[j + 1])
                    continue;

                (array[j], array[j + 1]) = (array[j + 1], array[j]);
            }

            if (anyChanges)
                break;
        }

        return array;
    }
}