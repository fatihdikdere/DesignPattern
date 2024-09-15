using Proxy;

var bankAccount = new BankAccount(500);

IBankAccount bankAccountProxy = new BankAccountProxy(bankAccount);

bankAccountProxy.Withdraw(1000);
bankAccountProxy.Withdraw(100);

Console.WriteLine($"Balance: {bankAccountProxy.Balance}"); ;

Console.ReadKey();