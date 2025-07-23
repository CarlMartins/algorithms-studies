namespace algorithms_studies.Problems.Arrays;

public static class LongestConsecutiveSequence_20250723
{
    public static int LongestConsecutive(int[] array)
    {
        if (array.Length == 0)
            return 0;

        if (array.Length == 1)
            return 1;
        
        var sortedArray = Sort(array);

        var currentSequence = 1;
        var longestSequence = 1;

        for (var i = 0; i < sortedArray.Length - 1; i++)
        {
            if (sortedArray[i + 1] == array[i] + 1)
            {
                currentSequence++;

                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                }
                
                continue;
            }

            if (sortedArray[i + 1] == array[i])
                continue;

            currentSequence = 1;
        }

        return longestSequence;
    }

    private static int[] Sort(int[] array)
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