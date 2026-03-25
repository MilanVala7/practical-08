namespace OOPConcepts.Domain.Models;

internal class Customer: Person
{
    //Composition(HAS-a Relationship)  because Customer has-a address, address is not a customer.
    public required Address Address { get; set; }

    // list to store Accounts of a customer.
    public List<BankAccount> Accounts { get; set; } = [];

    /// <summary>
    /// Purpose: Displays the Customer name and Address details.
    /// Return type: void
    /// </summary>
    public override void GetDetails()
    {
        Console.WriteLine($"Customer Name: {Name}");
        Console.WriteLine($"City: {Address.City}, State: {Address.State}");
    }
}
