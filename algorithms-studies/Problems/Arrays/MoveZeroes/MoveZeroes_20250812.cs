namespace algorithms_studies.Problems.Arrays.MoveZeroes;

public static class MoveZeroes_20250812
{
    public static int[] MoveZeroes(int[] array)
    {
        var writePointer = 0;
        
        for (var readPointer = 0; readPointer < array.Length; readPointer++)
        {
            if (array[readPointer] == 0)
                continue;

            (array[writePointer], array[readPointer]) = (array[readPointer], array[writePointer]);
            writePointer++;
        }

        return array;
    }
}