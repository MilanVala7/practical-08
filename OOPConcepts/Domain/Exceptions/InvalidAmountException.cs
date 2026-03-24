namespace OOPConcepts.Domain.Exceptions;

internal class InvalidAmountException: Exception
{
    public InvalidAmountException(string msg): base(msg) { }
}
