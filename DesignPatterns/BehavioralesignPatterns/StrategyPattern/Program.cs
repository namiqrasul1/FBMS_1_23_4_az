using StrategyPattern;

ShoppingCart shoppingCart = new();
shoppingCart.SetPaymentStratedy(new PayPalPayment("namiq@rasul.com"));
shoppingCart.SetPaymentStratedy(new CreditCardPayment("1234 5678 9123 4567"));
shoppingCart.Checkout(500);

