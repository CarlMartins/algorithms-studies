namespace algorithms_studies.Problems.Arrays;

public static class TwoSum_20250723
{
    public static int[] TwoSum(int[] array, int target)
    {
        for (var i = 0; i < array.Length; i++)
        {
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] != target)
                    continue;

                return [i, j];
            }
        }

        return [];
    }
}