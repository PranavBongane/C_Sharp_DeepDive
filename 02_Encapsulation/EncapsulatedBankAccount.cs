using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Encapsulation
{
    public class EncapsulatedBankAccount
    {
        private decimal balance { get; set; }

        public EncapsulatedBankAccount(decimal initialBalance)
        {
            if (initialBalance < 0)
                throw new InvalidOperationException("Initial balance cannot be negative.");
            balance = initialBalance;
        }

        //To get existing balance 
        public  decimal GetBalance => balance;


        //To Deposit balance 
        public string Deposit(decimal Amount)
        {
            if (decimal.IsNegative(Amount))
                throw new InvalidOperationException("Deposit Amount can not be negative");

            balance += Amount;

            return $"Amount deposited successfully; your Account balance is:  {balance}";
        }

        //To Withdraw balance 
        public string Withdraw(decimal Amount)
        {
            if (decimal.IsNegative(Amount))
                throw new InvalidOperationException("Withdraw Amount can not be negative");

            if (balance < Amount)
                throw new InvalidOperationException($"Withdraw Amount can not be greater than balance; your Account balance is:  {this.balance}");

            balance -= Amount;
            return $"Amount withdrawen successfully; your Account balance is:  {balance}";
        }
    }
}
