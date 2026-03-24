namespace OOPConcepts.Domain.Exceptions;

internal class InsufficientBalanceException: Exception
{
    public InsufficientBalanceException(string msg) : base(msg) { }
}
