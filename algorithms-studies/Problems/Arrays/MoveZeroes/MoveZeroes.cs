using algorithms_studies.BaseClasses;

namespace algorithms_studies.Problems.Arrays.MoveZeroes;

public class MoveZeroes : PrintBase
{
    private readonly int[] _array = [0, 1, 0, 3, 12];
    private const string ProblemName = "MOVE ZEROES";
    public MoveZeroes() : base(ProblemName)
    { }

    public MoveZeroes(int[] array) : base(ProblemName)
    {
        _array = array;
    }

    public void PrintMoveZeroes()
    {
        PrintHeader();
        
        MoveZeroes_20250812.MoveZeroes(_array.ToArray()).PrintArray();
        
        PrintFooter();
    }

    private void PrintHeader()
    {
        PrintTitle();
        PrintBaseArray(_array);
        PrintDivider();
    }
}