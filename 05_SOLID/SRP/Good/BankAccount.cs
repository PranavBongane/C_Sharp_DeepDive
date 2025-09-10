namespace _05_SOLID.SRP.Good
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount) => Balance += amount;
        public void Withdraw(decimal amount) => Balance -= amount;
    }

    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}