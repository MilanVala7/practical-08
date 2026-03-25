
public class TransactionService: ITransaction
{
    private readonly IAccountRepository repo;

    public TransactionService(IAccountRepository r)
    {
        repo = r;
    }

    /// <summary>
    /// Purpose: To tranfer money from one account to another account.
    /// Return type: boolen
    /// </summary>
    /// <param name="acc1">Source account object. from which the amount will be withdrawn</param>
    /// <param name="acc2">Destination account object. to which the amount will be deposited</param>
    /// <param name="amount">amount to be transfered from acc1 to acc2</param>
    public bool Transfer(BankAccount acc1, BankAccount acc2, double amount)
    {
        if(acc1 == acc2)
            throw new Exception("Cannot transfer to same account");

        acc1.Withdraw(amount);
        acc2.Deposite(amount);

        // Save the Trasaction details into Transactions List.
        acc1.Transactions.Add($"Transferred {amount} to {acc2.AccountNo}");
        acc2.Transactions.Add($"Received {amount} from {acc1.AccountNo}");

        repo.Save(acc1);
        repo.Save(acc2);

        Console.WriteLine("Transfer Successful");
        return true;
    }
}
