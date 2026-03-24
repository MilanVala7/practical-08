internal class SavingsAccount: BankAccount
{
    public SavingsAccount(string accNo, Customer cus): base(accNo, cus) { }
    public override void CalculateInterest()
    {
        double interest = Balance * 0.05;
        Console.WriteLine("Savings Interest Applied");
    }
}
