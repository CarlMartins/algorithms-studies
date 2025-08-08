namespace algorithms_studies.Problems.Arrays;

public static class TwoSum_20250728
{
    public static int[] TwoSum(int[] array, int k)
    {
        var differences = new Dictionary<int, int>();

        for (var i = 0; i < array.Length; i++)
        {
            var difference = k - array[i];

            if (differences.ContainsValue(array[i]))
            {
                return [i, differences.First(x => x.Value == array[i]).Key];
            }
            
            differences.Add(i, difference);
        }

        return [];
    }
}