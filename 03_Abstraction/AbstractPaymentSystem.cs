using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstraction
{
    public abstract class AbstractPaymentSystem
    {
        public decimal Amount { get; set; }
        public abstract void MakePayment();

        public void PrintReceipt()
        {
            Console.WriteLine($"Payment of {Amount:C} processed successfully.");
        }
    }

    public class CreditCardPayment : AbstractPaymentSystem
    {
        public override void MakePayment()
        {
            Console.WriteLine($"Processing Credit Card payment of {Amount:C}...");
            Console.WriteLine("Credit Card validated and transaction approved.");
        }
    }

    public class PayPalPayment : AbstractPaymentSystem
    {
        public override void MakePayment()
        {
            Console.WriteLine($"Processing PayPal payment of {Amount:C}...");
            Console.WriteLine("PayPal account verified, payment completed.");
        }
    }

    public class UpiPayment : AbstractPaymentSystem
    {
        public override void MakePayment()
        {
            Console.WriteLine($"Processing UPI payment of {Amount:C}...");
            Console.WriteLine("UPI PIN verified, transaction successful.");
        }
    }
}
