using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstraction
{
    // BAD example: No abstraction, everything dumped in one class
    public class BadPaymentSystem
    {
        public void MakePayment(string method, decimal amount)
        {
            if (method == "CreditCard")
            {
                Console.WriteLine($"Processing Credit Card payment of {amount:C}...");
                Console.WriteLine("Credit Card validated and transaction approved.");
            }
            else if (method == "PayPal")
            {
                Console.WriteLine($"Processing PayPal payment of {amount:C}...");
                Console.WriteLine("PayPal account verified, payment completed.");
            }
            else if (method == "UPI")
            {
                Console.WriteLine($"Processing UPI payment of {amount:C}...");
                Console.WriteLine("UPI PIN verified, transaction successful.");
            }
            else
            {
                Console.WriteLine("Invalid payment method.");
            }

            Console.WriteLine($"Payment of {amount:C} processed successfully.");
        }
    }
}
