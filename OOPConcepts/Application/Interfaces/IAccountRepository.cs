using OOPConcepts.Domain.Models;

public interface IAccountRepository
{
    /// <summary>
    /// Saves the bank account to the Accounts List.
    /// </summary>
    /// <param name="account">bank account to be saved</param>
    void Save(BankAccount account);
}
