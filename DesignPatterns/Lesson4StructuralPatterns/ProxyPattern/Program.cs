using ProxyPattern;

IBankAccount userBankAccount = new BankAccountProxy("User");

userBankAccount.Deposit(100);
userBankAccount.Withdraw(50);
userBankAccount.GetBalance();