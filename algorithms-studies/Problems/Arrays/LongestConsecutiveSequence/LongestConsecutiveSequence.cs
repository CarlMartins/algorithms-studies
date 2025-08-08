using System.Reflection.PortableExecutable;
using algorithms_studies.BaseClasses;

namespace algorithms_studies.Problems.Arrays.LongestConsecutiveSequence;

public class LongestConsecutiveSequence : PrintBase
{
    private readonly int[] _array = [ 4, 7, 5, 12, 6, 43, 24, 9 ];
    private const string ProblemName = "ARRAYS - LONGEST CONSECUTIVE SEQUENCE";

    public LongestConsecutiveSequence() : base(ProblemName)
    { }
    
    public LongestConsecutiveSequence(int[] array) : base(ProblemName)
    {
        _array = array;
    }

    public void PrintLongestConsecutiveSequence()
    {
        PrintHeader();
        
        LongestConsecutiveSequence_20250722.LongestConsecutive(_array.ToArray()).PrintInteger("2025-07-22");
        LongestConsecutiveSequence_20250723.LongestConsecutive(_array.ToArray()).PrintInteger("2025-07-23");
        LongestConsecutiveSequence_20250726.LongestConsecutive(_array.ToArray()).PrintInteger("2025-07-26");
        LongestConsecutiveSequence_20250807.LongestConsecutive(_array.ToArray()).PrintInteger("2025-08-07");
        
        PrintFooter();
    }

    private void PrintHeader()
    {
        PrintTitle();
        PrintBaseArray(_array);
        PrintDivider();
    }
}