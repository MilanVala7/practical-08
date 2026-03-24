namespace OOPConcepts.Application.Interfaces;

public interface ITransaction
{
    bool Transfer(BankAccount acc1, BankAccount acc2, double amount);
}
