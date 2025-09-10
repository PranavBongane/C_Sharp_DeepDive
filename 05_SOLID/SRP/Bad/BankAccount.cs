namespace _05_SOLID.SRP.Bad
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount) => Balance += amount;
        public void Withdraw(decimal amount) => Balance -= amount;

        // ❌ Wrong: Logging in the same class
        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}