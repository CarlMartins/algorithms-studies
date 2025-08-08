using algorithms_studies.BaseClasses;

namespace algorithms_studies.Problems.Arrays;

public class RotateByK : PrintBase
{
    private const string ProblemName = "ARRAYS - ROTATE BY K";
    private readonly int[] Array = [ 1, 2, 3, 4, 5, 6, 7 ];
    private const int K = 2;
    
    public RotateByK() : base(ProblemName)
    { }
    
    public RotateByK(int[] array) : base(ProblemName)
    {
        Array = array;
    }

    public void PrintRotateByK()
    {
        PrintHeader();

        RotateByK_20250720.RorateRight(Array, 2).PrintArray("2025-07-20");
        
        PrintFooter();
    }
    
    private void PrintHeader()
    {
        PrintTitle();
        PrintBaseArray(Array);
        PrintK();
        PrintDivider();
    }
    
    private void PrintK()
    {
        Console.WriteLine($"K: {K}");
    }
}