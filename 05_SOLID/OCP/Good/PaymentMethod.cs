namespace _05_SOLID.OCP.Good
{
    public abstract class PaymentMethod
    {
        public abstract void Pay(decimal amount);
    }

    public class CreditCard : PaymentMethod
    {
        public override void Pay(decimal amount) =>
            Console.WriteLine($"Paid {amount} using Credit Card");
    }

    public class PayPal : PaymentMethod
    {
        public override void Pay(decimal amount) =>
            Console.WriteLine($"Paid {amount} using PayPal");
    }
}