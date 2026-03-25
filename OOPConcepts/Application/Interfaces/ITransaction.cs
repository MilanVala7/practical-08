namespace OOPConcepts.Application.Interfaces;

public interface ITransaction
{
    /// <summary>
    /// Purpose: Transfers the specified amount from one bank account to another.
    /// Return type: Boolen
    /// </summary>
    /// <param name="acc1">The source bank account from which the amount will be withdrawn</param>
    /// <param name="acc2">The destination bank account to which the amount will be deposited</param>
    /// <param name="amount">The amount of money to transfer</param>
    
    bool Transfer(BankAccount acc1, BankAccount acc2, double amount);
}
