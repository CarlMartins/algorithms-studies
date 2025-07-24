namespace algorithms_studies.Problems.Arrays;

public static class TwoSum_20250723_3
{
    public static int[] TwoSum(int[] array, int target)
    {
        var hash = new Dictionary<int, int>();

        for (int i = 0; i < array.Length; i++)
        {
            var difference = target - array[i];
            
            if (!hash.ContainsValue(array[i]))
            {
                hash.Add(i, difference);
                continue;
            }

            return [i, hash.First(x => x.Value == array[i]).Key];
        }
        
        return [];
    }
}