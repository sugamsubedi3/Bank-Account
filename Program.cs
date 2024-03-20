using System;

public class Account
{
    // Properties
    public string AccountNumber { get; }
    public decimal Balance { get; private set; }
    public string Type { get; }

    // Constructors
    public Account(string accountNumber, decimal initialBalance, string type = "Checking")
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        Type = type;
    }

    // Methods
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }

        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be greater than zero.");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawn {amount:C}. New balance: {Balance:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a checking account
        Account checkingAccount = new Account("123456789", 1000);

        // Deposit and Withdrawal operations
        checkingAccount.Deposit(500);
        checkingAccount.Withdraw(200);
    }
}
