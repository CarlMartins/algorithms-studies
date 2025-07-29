namespace algorithms_studies.Algorithms.Sorting.BubbleSort;

public static class Bubble20250729
{
    public static int[] Sort(int[] array)
    {
        for (var i = array.Length - 1; i > 0; i--)
        {
            var hasAnyChanges = false;

            for (var j = 0; j < i; j++)
            {
                if (array[j + 1] >= array[j])
                    continue;

                (array[j], array[j + 1]) = (array[j + 1], array[j]);
                hasAnyChanges = true;
            }

            if (!hasAnyChanges)
                break;
        }

        return array;
    }
}