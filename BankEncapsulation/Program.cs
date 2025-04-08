namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var petersAccount = new BankAccount();
            
            Console.WriteLine("Enter the amount to deposit:");
            
            var amountToDep = double.Parse(Console.ReadLine());
            
            petersAccount.Deposit(amountToDep);
            
            Console.WriteLine($"Your balance is: {petersAccount.GetBalance()}");
        }
    }
}
