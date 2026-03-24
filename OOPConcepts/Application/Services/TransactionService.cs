
public class TransactionService: ITransaction
{
    private readonly IAccountRepository repo;

    public TransactionService(IAccountRepository r)
    {
        repo = r;
    }
    public bool Transfer(BankAccount acc1, BankAccount acc2, double amount)
    {
        if(acc1 == acc2)
            throw new Exception("Cannot transfer to same account");

        acc1.Withdraw(amount);
        acc2.Deposite(amount);

        acc1.Transactions.Add($"Transferred {amount} to {acc2.AccountNo}");
        acc2.Transactions.Add($"Received {amount} from {acc1.AccountNo}");

        repo.Save(acc1);
        repo.Save(acc2);

        Console.WriteLine("Transfer Successful");
        return true;
    }
}
