namespace algorithms_studies.BaseClasses;

public abstract class PrintBase
{
    private readonly string _name;

    protected PrintBase()
    {
        _name = "Base";
    }

    protected PrintBase(string name)
    {
        _name = name;
    }

    protected void PrintTitle()
    {
        Console.WriteLine($"____________{_name}____________");   
    }

    protected void PrintDivider()
    {
        Console.WriteLine(""); 
    }

    protected void PrintFooter(int length = 50)
    {
        const char footerChar = '█';
        string footer = new string(footerChar, length);
        Console.WriteLine($"\n{footer}\n");

    }
    
    protected virtual void PrintBaseArray(int[] array)
    {
        Console.WriteLine($"Array: [{array.GetFormatedArray()}]");
    }
    
    protected virtual void PrintTargetValue(int target)
    {
        Console.WriteLine($"Target: {target}");
    }
}