namespace _05_SOLID.OCP.Bad
{
    public class PaymentProcessor
    {
        public void Process(string type, decimal amount)
        {
            if (type == "CreditCard")
                Console.WriteLine($"Paid {amount} using Credit Card");
            else if (type == "PayPal")
                Console.WriteLine($"Paid {amount} using PayPal");
            // ❌ Need to modify this every time we add new type
        }
    }
}