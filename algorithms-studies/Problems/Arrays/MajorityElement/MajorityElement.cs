using algorithms_studies.BaseClasses;

namespace algorithms_studies.Problems.Arrays.MajorityElement;

public class MajorityElement : PrintBase
{
    private const string ProblemName = "MAJORITY ELEMENT";
    private readonly int[] _array = [2, 2, 1, 1, 1, 2, 2, 4, 4, 4, 4, 4];

    public MajorityElement() : base(ProblemName)
    {
    }

    public MajorityElement(int[] array) : base(ProblemName)
    {
        _array = array;
    }

    public void PrintMajorityElement()
    {
        PrintHeader();

        MajorityElement_20250811.PrintMajority(_array).PrintInteger("2025-08-11");

        PrintFooter();
    }

    private void PrintHeader()
    {
        PrintTitle();
        PrintBaseArray(_array);
        PrintDivider();
    }
}