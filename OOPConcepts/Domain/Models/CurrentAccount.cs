namespace OOPConcepts.Domain.Models;

internal class CurrentAccount: BankAccount
{
    public CurrentAccount(string accNo, Customer cus): base(accNo, cus) { }

    /// <summary>
    /// Purpose: Calaculate interest for current account. 
    /// Return type: void
    /// </summary>
    // Overridden method of BankAccount class.
    public override void CalculateInterest()
    {
        Console.WriteLine("No interest for Current Account");
    }
}
