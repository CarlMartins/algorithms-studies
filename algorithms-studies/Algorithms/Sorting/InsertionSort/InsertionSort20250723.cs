namespace algorithms_studies.Algorithms.Sorting.InsertionSort;

public static class InsertionSort20250723
{
    public static int[] Sort(int[] array)
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

        return array;
    }
}