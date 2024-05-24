using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class BankAccountProxy : IBankAccount
    {
        private BankAccount _realBankAccount;
        private string _userRole;

        public BankAccountProxy(string userRole)
        {
            _realBankAccount = new BankAccount();
            _userRole = userRole;
        }

        public void Deposit(decimal amount)
        {
            if (_userRole == "Admin" || _userRole == "User")
                _realBankAccount.Deposit(amount);
            else
                Console.WriteLine("Access denied");
        }

        public decimal GetBalance()
        {
            if (_userRole == "Admin")
                return _realBankAccount.GetBalance();

            Console.WriteLine("Access denied");
            return 0;
        }

        public void Withdraw(decimal amount)
        {
            if (_userRole == "Admin" || _userRole == "User")
                _realBankAccount.Withdraw(amount);
            else
                Console.WriteLine("Access denied");
        }
    }
}
