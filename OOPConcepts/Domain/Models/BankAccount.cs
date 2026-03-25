namespace OOPConcepts.Domain.Models;

public abstract class BankAccount
{
    public string AccountNo { get; private set; }

    internal Customer Customer { get; private set; }

    // Encapsulation using Properties.
    private double balance;
    public double Balance
    {
        get { return balance; }
        protected set { balance = value; }
    }

    //list to store the transactions history. to keep track of transaction.
    public List<string> Transactions { get; } = new List<string>();

    internal BankAccount(string accNo, Customer cust)
    {
        AccountNo = accNo;
        Customer = cust;
    }

    /// <summary>
    /// Purpose: to deposite amount into account and display current balance
    /// return type: void
    /// </summary>
    /// <param name="amount">amount to be add into account</param>
    public virtual void Deposite(double amount)
    {
        if(amount <= 0)
            throw new InvalidAmountException("Amount must be greater than zero");

        balance += amount;
        Console.WriteLine($"Deposited Amount: {amount}");

        Console.WriteLine("Current Balance: " + Balance);
    }

    //Method Overloading:
    /// <summary>
    /// Purpose: to deposite amount into account with notes
    /// Return type: void
    /// </summary>
    /// <param name="amount">amount to be add into account</param>
    /// <param name="note">specific message(note)</param>
    public virtual void Deposit(double amount, string note)
    {
        if (amount <= 0)
            throw new InvalidAmountException("Invalid deposit amount");

        balance += amount;
        Transactions.Add($"Deposited Amount: {amount} ({note})");
        Console.WriteLine($"Deposited Amount: {amount} ({note})");

        Console.WriteLine("Current Balance: " + Balance);
    }

    /// <summary>
    /// Purpose: to withdraw amount from account and displays available balance.
    /// Return type: void
    /// </summary>
    /// <param name="amount">amount to be withdraw from account</param>
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
    /// <summary>
    /// Purpose: to withdraw amount from account with notes(reason)
    /// Return type: void
    /// </summary>
    /// <param name="amount">amount to be withdraw from account</param>
    /// <param name="note">specific message(reason)</param>
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


    /// <summary>
    /// Purpose: Calculate interest based on derived account type(derived class).
    /// Return type: void
    /// </summary>
    public abstract void CalculateInterest();
}
