using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstraction.PaymentContracts
{
    public interface IPayment
    {
        decimal Amount { get; set; }
        void MakePayment();
        void PrintReceipt();
    }
}
