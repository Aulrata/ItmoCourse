// See https://aka.ms/new-console-template for more information

using M17.T1;

Console.WriteLine("Hello, World!");

Account<int> account = new(1, 100, "Roman", "Badin", "Evgenievich");
Console.WriteLine(account.ToString());

Console.WriteLine("Пополнеине -100");
account.TopUp(-100);
Console.WriteLine(account.ToString());

Console.WriteLine("Пополнеине 100");
account.TopUp(100);
Console.WriteLine(account.ToString());

Console.WriteLine("Снятие -100");
account.Withdraw(-100);
Console.WriteLine(account.ToString());

Console.WriteLine("Снятие 1000");
account.Withdraw(1000);
Console.WriteLine(account.ToString());

Console.WriteLine("Снятие 50");
account.Withdraw(50);
Console.WriteLine(account.ToString());

Account<string> account2 = new("Number 2", 200, "Dima", "Ivanov", "Ivanovich");
Console.WriteLine(account2.ToString());
