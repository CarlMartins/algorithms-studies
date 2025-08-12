namespace algorithms_studies.Problems.Arrays.MajorityElement;

public static class MajorityElement_20250811
{
    public static int PrintMajority(int[] array)
    {
        if (array.Length == 0)
            return -1;
        
        var minimumQty = (array.Length / 2) + 1;
        var numbers = new Dictionary<int, int>();

        foreach (var num in array)
        {
            if (!numbers.ContainsKey(num))
                numbers[num] = 0;

            numbers[num]++;

            if (numbers[num] >= minimumQty)
                return num;
        }

        return numbers.MaxBy(x => x.Value).Key;
    }
}