class Program
{
    static void Main()
    {
        try
        {
            IAccountRepository repo = new AccountRepository();
            ITransaction ts = new TransactionService(repo);

            Address add = new Address { City = "Ahmedabad", State = "Gujarat" };

            Customer c = new Customer { Name = "Milan", Address = add };

            c.GetDetails();
            Console.WriteLine();

            BankAccount SavingsAcc1 = new SavingsAccount("ACC101", c);
            BankAccount currentAcc2 = new CurrentAccount("ACC102", c);

            // Assign bank accounts to customers
            c.Accounts.Add(SavingsAcc1);
            c.Accounts.Add(currentAcc2);

            SavingsAcc1.Deposite(5000);
            SavingsAcc1.Deposit(2000, "Salary");
            Console.WriteLine();

            SavingsAcc1.Withdraw(2000);
            SavingsAcc1.Withdraw(500, "UPI to friend");
            Console.WriteLine();

            Console.WriteLine("Transfer:");
            ts.Transfer(SavingsAcc1, currentAcc2, 1000);

            ts.Transfer(SavingsAcc1, currentAcc2, -500); //error

            Console.WriteLine($"Savings Balance: {SavingsAcc1.Balance}");
            Console.WriteLine($"Current Balance: {currentAcc2.Balance}");

            SavingsAcc1.CalculateInterest();
            currentAcc2.CalculateInterest();
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidAmountException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
    }
   
}