using _02_Encapsulation;

// ---------------- BadBankAccount Demo ----------------
Console.WriteLine("=== BadBankAccount Demo ===");
BadBankAccount bad = new BadBankAccount();

Console.WriteLine("Setting initial balance to 200 directly...");
bad.balance = 200;
Console.WriteLine($"Bad Account balance: {bad.balance}");

Console.WriteLine("\nDepositing +100 directly...");
bad.balance += 100;
Console.WriteLine($"Bad Account balance: {bad.balance}");

Console.WriteLine("\nDepositing -100 directly (NOT SAFE)...");
bad.balance += -100; // invalid but still allowed
Console.WriteLine($"Bad Account balance: {bad.balance}");

Console.WriteLine("\nWithdrawing 1000 directly (can withdraw more than balance)...");
bad.balance -= 1000;
Console.WriteLine($"Bad Account balance: {bad.balance}");

Console.WriteLine("\nWithdrawing -100 directly (NOT SAFE)...");
bad.balance -= -100;
Console.WriteLine($"Bad Account balance: {bad.balance}");


// ---------------- EncapsulatedBankAccount Demo ----------------
Console.WriteLine("\n=== EncapsulatedBankAccount Demo ===");
EncapsulatedBankAccount good = new EncapsulatedBankAccount(1000);

Console.WriteLine($"Initial balance: {good.GetBalance}");

Console.WriteLine("\nDepositing 1000...");
Console.WriteLine(good.Deposit(1000));
Console.WriteLine($"Encapsulated Account balance: {good.GetBalance}");

Console.WriteLine("\nTrying to deposit -1000...");
try
{
    Console.WriteLine(good.Deposit(-1000));
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
Console.WriteLine($"Encapsulated Account balance: {good.GetBalance}");

Console.WriteLine("\nWithdrawing 1000...");
Console.WriteLine(good.Withdraw(1000));
Console.WriteLine($"Encapsulated Account balance: {good.GetBalance}");

Console.WriteLine("\nTrying to withdraw -1000...");
try
{
    Console.WriteLine(good.Withdraw(-1000));
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
Console.WriteLine($"Encapsulated Account balance: {good.GetBalance}");

Console.WriteLine("\nTrying to withdraw 10000 (more than balance)...");
try
{
    Console.WriteLine(good.Withdraw(10000));
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
Console.WriteLine($"Encapsulated Account balance: {good.GetBalance}");
