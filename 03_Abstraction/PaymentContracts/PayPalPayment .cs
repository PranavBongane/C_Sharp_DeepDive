using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstraction.PaymentContracts
{
    public class _PayPalPayment:IPayment
    {
        public decimal Amount { get; set; }

        public void MakePayment()
        {
            Console.WriteLine($"Processing PayPal payment of {Amount:C}...");
            Console.WriteLine("PayPal account verified, payment completed.");
        }

        public void PrintReceipt()
        {
            Console.WriteLine($"[Receipt] PayPal Payment of {Amount:C} completed.");
        }
    }
}
