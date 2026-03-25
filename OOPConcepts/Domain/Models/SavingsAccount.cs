namespace OOPConcepts.Domain.Models;
internal class SavingsAccount(string accNo, Customer cus) : BankAccount(accNo, cus)
{
    /// <summary>
    /// Purpose: Calculate interest for Saving account with 5% interest.
    /// Return type: void
    /// </summary>
    // Overridden method of BankAccount Class.
    public override void CalculateInterest()
    {
        double interest = Balance * 0.05;
        Console.WriteLine("Savings Interest Applied");
    }
}
