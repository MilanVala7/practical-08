using OOPConcepts.Domain.Models;

namespace OOPConcepts.Application.Services;

internal class AccountRepository: IAccountRepository
{
    private readonly List<BankAccount> accs = new();

    public void Save(BankAccount account)
    {
        if (!accs.Contains(account))
            accs.Add(account);
    }
}
