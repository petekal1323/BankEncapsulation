using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        private double balance = 0;
        
        // define a method namned Deposit that takes a double
        // and stores it in the balance field
        
        public void Deposit(double amount)
        { 
            balance = amount;
        }
        
        // define a method named getBalance that returns the balance field
        
        public double GetBalance()
        {
            return balance;
        }
    }
}