using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstraction.PaymentContracts
{
    public class _UpiPayment : IPayment
    {
        public decimal Amount { get; set; }

        public void MakePayment()
        {
            Console.WriteLine($"Processing UPI payment of {Amount:C}...");
            Console.WriteLine("UPI PIN verified, transaction successful.");
        }

        public void PrintReceipt()
        {
            Console.WriteLine($"[Receipt] UPI Payment of {Amount:C} completed.");
        }

    }
}
