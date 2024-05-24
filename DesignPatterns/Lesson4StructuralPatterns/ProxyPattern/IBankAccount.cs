using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal interface IBankAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal GetBalance();
    }
}
