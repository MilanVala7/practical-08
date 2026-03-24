namespace OOPConcepts.Domain.Models;

internal class CurrentAccount: BankAccount
{
    public CurrentAccount(string accNo, Customer cus): base(accNo, cus) { }

    public override void CalculateInterest()
    {
        Console.WriteLine("No interest for Current Account");
    }
}
