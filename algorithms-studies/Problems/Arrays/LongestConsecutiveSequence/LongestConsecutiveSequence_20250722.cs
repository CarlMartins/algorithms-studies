namespace algorithms_studies.Problems.Arrays.LongestConsecutiveSequence;

public static class LongestConsecutiveSequence_20250722
{
    public static int LongestConsecutive(int[] array)
    {
        if (array.Length == 0)
            return 0;
        
        var sortedArray = InsertionSort(array);
        var currentSequence = 1;
        var largestSequence = 1;

        if (array.Length == 1)
            return currentSequence;

        for (var i = 0; i < sortedArray.Length - 1; i++)
        {
            if (sortedArray[i + 1] == sortedArray[i] + 1)
            {
                currentSequence++;
                continue;
            }

            if (sortedArray[i + 1] == sortedArray[i])
                continue;

            if (currentSequence > largestSequence)
            {
                largestSequence = currentSequence;
            }
            
            currentSequence = 1;
        }
        
        if (currentSequence > largestSequence)
        {
            largestSequence = currentSequence;
        }

        return largestSequence;
    }

    private static int[] InsertionSort(int[] array)
    {
        for (var i = 1; i < array.Length; i++)
        {
            var key = array[i];
            var j = i - 1;

            while (j >= 0 && key <= array[j])
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }

        return array;
    }
}