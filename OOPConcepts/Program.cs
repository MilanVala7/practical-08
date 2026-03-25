class Program
{
    static void Main()
    {
        try
        {
            IAccountRepository repo = new AccountRepository();
            TransactionService ts = new TransactionService(repo);

            Address add = new Address { City = "Ahmedabad", State = "Gujarat" };

            Customer c = new Customer { Name = "Milan", Address = add };

            //Displays the details of Customer.
            c.GetDetails();
            Console.WriteLine();

            BankAccount SavingsAcc1 = new SavingsAccount("ACC101", c);
            BankAccount currentAcc2 = new CurrentAccount("ACC102", c);

            // Add(Assign) bank accounts to customers
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

            //error : Shows invalid amount
            ts.Transfer(SavingsAcc1, currentAcc2, -500); 

            Console.WriteLine($"Savings Balance: {SavingsAcc1.Balance}");
            Console.WriteLine($"Current Balance: {currentAcc2.Balance}");

            SavingsAcc1.CalculateInterest();
            currentAcc2.CalculateInterest();
        }
        catch (InsufficientBalanceException e)
        {
            // catch the exception if required amount is greater then balance. 
            Console.WriteLine(e.Message);
        }
        catch (InvalidAmountException e)
        {
            // catch the exception if invalid(zero or negative) amount is inserted.
            Console.WriteLine(e.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
    }
   
}