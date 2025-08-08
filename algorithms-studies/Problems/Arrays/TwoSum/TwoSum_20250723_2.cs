namespace algorithms_studies.Problems.Arrays;

public static class TwoSum_20250723_2
{
    // Doesn't work, verify later
    public static int[] TwoSum(int[] array, int target)
    {
        var sortedArray = Sort(array);

        var currentLeftIndex = 0;
        var currentRigthIndex = sortedArray.Length - 1;

        while (true)
        {
            var sum = sortedArray[currentLeftIndex] + sortedArray[currentRigthIndex];
            
            if (sum == target)
                return [currentLeftIndex, currentRigthIndex];

            if (sum > target)
            {
                currentRigthIndex--;
                continue;
            }

            if (sum < target)
                currentLeftIndex++;
        }
    }

    private static int[] Sort(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var lowestValueIndex = i;

            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[j] >= array[lowestValueIndex])
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