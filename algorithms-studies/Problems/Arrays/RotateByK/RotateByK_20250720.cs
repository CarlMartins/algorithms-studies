namespace algorithms_studies.Problems.Arrays;

public static class RotateByK_20250720
{
    public static int[] RorateRight(int[] nums, int k)
    {
        int n = nums.Length;
        k = k % n;

        if (k == 0)
            return nums;

        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            result[(i + k) % n] = nums[i];
        }

        return result;
    }
}