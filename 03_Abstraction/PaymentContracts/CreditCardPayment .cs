using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstraction.PaymentContracts
{
    internal class _CreditCardPayment:IPayment
    {
        public decimal Amount { get; set; }

        public void MakePayment()
        {
            Console.WriteLine($"Processing Credit Card payment of {Amount:C}...");
            Console.WriteLine("Credit Card validated and transaction approved.");
        }

        public void PrintReceipt()
        {
            Console.WriteLine($"[Receipt] CreditCard Payment of {Amount:C} completed.");
        }
    }
}
