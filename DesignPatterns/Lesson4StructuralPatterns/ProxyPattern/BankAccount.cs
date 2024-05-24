using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class BankAccount : IBankAccount
    {
        private decimal _balance;

        public void Deposit(decimal amount)
        {
            _balance += amount;
            Console.WriteLine($"{amount} deposited. New balance {_balance}");
        }

        public decimal GetBalance() => _balance;

        public void Withdraw(decimal amount)
        {
            if(amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"{amount} withdrawn. New balance: {_balance}");
            }
            else
                Console.WriteLine("Not enough money");
        }
        List<BankAccount> _
    }
}
