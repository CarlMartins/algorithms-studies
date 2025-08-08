namespace algorithms_studies.Exceptions;

public class NotOrderedArrayException : Exception
{
    public NotOrderedArrayException()
    { }
     
    public NotOrderedArrayException(string message) : base(message)
    { }
}