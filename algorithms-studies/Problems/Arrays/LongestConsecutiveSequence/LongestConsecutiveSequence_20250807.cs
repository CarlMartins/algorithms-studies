namespace algorithms_studies.Problems.Arrays.LongestConsecutiveSequence;

public static class LongestConsecutiveSequence_20250807
{
    public static int LongestConsecutive(int[] array)
    {
        if (array.Length == 1)
            return 1;

        if (array.Length == 0)
            return 0;

        var longestSequence = 1;
        var currentSequence = 1;

        InsertionSort(array);

        for (var i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] == array[i])
                continue;

            if (array[i + 1] == array[i] + 1)
            {
                currentSequence++;

                if (currentSequence > longestSequence)
                    longestSequence = currentSequence;

                continue;
            }

            currentSequence = 1;
        }

        return longestSequence;
    }

    private static void InsertionSort(int[] array)
    {
        for (var i = 1; i < array.Length; i++)
        {
            var key = array[i];
            var j = i - 1;

            while (j >= 0 && key < array[j])
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }
}