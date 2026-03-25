namespace OOPConcepts.Application.Services;

internal class AccountRepository: IAccountRepository
{
    // list of accounts 
    private readonly List<BankAccount> accs = [];

    /// <summary>
    /// Purpose: save the account to the Accounts list.
    /// return type: void
    /// </summary>
    /// <param name="account">account to be inserted into list</param>
    public void Save(BankAccount account)
    {
        if (!accs.Contains(account))
            accs.Add(account);
    }
}
