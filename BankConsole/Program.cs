using BankConsole;

User nelson = new User(1, "Nelson", "nelsonortiz102@gmail.com", 100);
Console.WriteLine(nelson.ShowData());

Storage.AddUser(nelson);

nelson.Deposit(1000);
System.Console.WriteLine(nelson.ShowData());

nelson.Charge(2000);
System.Console.WriteLine(nelson.ShowData("NO SE PUDO REALIZAR LA OPERACION"));

User yureli = new User(2, "Yureli", "yureliortiz@gmail.com", 100);
// Console.WriteLine(yureli.ShowData());

Storage.AddUser(yureli);