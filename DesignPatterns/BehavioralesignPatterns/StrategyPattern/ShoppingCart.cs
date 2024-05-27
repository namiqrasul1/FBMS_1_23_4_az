using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class ShoppingCart
    {
        private IPaymentStrategy _strategy;

        public void SetPaymentStratedy(IPaymentStrategy strategy) => _strategy = strategy;

        public void Checkout(decimal amount)
        {
            _strategy.Pay(amount);
        }
    }
}
