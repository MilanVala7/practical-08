namespace OOPConcepts.Domain.Models;

internal class Customer: Person
{
    public Address Address { get; set; }
    public List<BankAccount> Accounts { get; set; } = new();

    public override void GetDetails()
    {
        Console.WriteLine($"Customer Name: {Name}");
        Console.WriteLine($"City: {Address.City}, State: {Address.State}");
    }
}
