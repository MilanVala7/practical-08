namespace OOPConcepts.Domain.Models;

public abstract class BankAccount
{
    public string AccountNo { get; private set; }
    internal Customer Customer { get; private set; }

    private double balance;
    public double Balance
    {
        get { return balance; }
        protected set { balance = value; }
    }
    public List<string> Transactions { get; } = new();

    internal BankAccount(string accNo, Customer cust)
    {
        AccountNo = accNo;
        Customer = cust;
    }

    public virtual void Deposite(double amount)
    {
        if(amount <= 0)
            throw new InvalidAmountException("Amount must be greater than zero");

        balance += amount;
        Console.WriteLine($"Deposited Amount: {amount}");

        Console.WriteLine("Current Balance: " + Balance);
    }

    //Method Overloading:
    public virtual void Deposit(double amount, string note)
    {
        if (amount <= 0)
            throw new InvalidAmountException("Invalid deposit amount");

        balance += amount;
        Transactions.Add($"Deposited Amount: {amount} ({note})");
        Console.WriteLine($"Deposited Amount: {amount} ({note})");

        Console.WriteLine("Current Balance: " + Balance);
    }


    public virtual void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new InvalidAmountException("Invalid withdrawal amount");

        if (balance < amount)
            throw new InsufficientBalanceException("Insufficient Balance");

        balance -= amount;
        Console.WriteLine($"Withdrawn Amount: {amount}");
        Console.WriteLine("Available Balance: " + Balance);
    }
    //method overloading
    public virtual void Withdraw(double amount, string reason)
    {
        if (amount <= 0)
            throw new InvalidAmountException("Invalid withdrawal amount");

        if (amount > balance)
            throw new InsufficientBalanceException("Insufficient Balance");

        balance -= amount;
        Transactions.Add($"Withdrawn Amount: {amount} ({reason})");
        Console.WriteLine($"Withdrawn Amount: {amount} ({reason})");
        Console.WriteLine("Available Balance: " + Balance);
    }

    public abstract void CalculateInterest();
}
