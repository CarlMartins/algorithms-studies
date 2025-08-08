using algorithms_studies.BaseClasses;

namespace algorithms_studies.Problems.Arrays;

public class TwoSum : PrintBase
{
    private const string ProblemName = "ARRAYS - TWO SUM";
    private readonly int[] _array = [ 2, 7, 11, 15 ];
    private readonly int _target = 9;
    
    public TwoSum(int[] array, int target) : base(ProblemName)
    {
        _array = array;
        _target = target;
    }
    public TwoSum() : base(ProblemName)
    { }

    public void PrintTwoSum()
    {
        PrintHeader();
        
        TwoSum_20250723.TwoSum(_array, _target).PrintArray("2025-07-23");
        TwoSum_20250723_2.TwoSum(_array, _target).PrintArray("2025-07-23");
        TwoSum_20250723_3.TwoSum(_array, _target).PrintArray("2025-07-23");
        TwoSum_20250728.TwoSum(_array, _target).PrintArray("2025-07-28");
        
        PrintFooter();
    }
    
    private void PrintHeader()
    {
        PrintTitle();
        PrintBaseArray(_array);
        PrintTarget();
        PrintDivider();
    }
    
    private void PrintTarget()
    {
        Console.WriteLine($"Target: {_target}");
    }
}