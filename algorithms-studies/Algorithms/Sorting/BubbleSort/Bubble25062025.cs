namespace algorithms_studies.Algorithms.Sorting.BubbleSort;

public static class Bubble25062025
{
    public static int[] Sort(int[] array)
    {
        for (var i = array.Length - 1; i > 0; i--)
        {
            var changes = 0;

            for (var j = 0; j < i; j++)
            {
                if (array[j] <= array[j + 1]) 
                    continue;
                
                (array[j], array[j + 1]) = (array[j + 1], array[j]);
                changes++;
            }
            
            if (changes == 0) break;
        }
        
        return array;
    }
}