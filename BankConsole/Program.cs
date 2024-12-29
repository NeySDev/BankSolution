using BankConsole;

User nelson = new User();

nelson.ID = 1;
nelson.Name = "Nelson";
nelson.Email = "nelsonortiz102@gmail.com";
nelson.Balance = 1000;
nelson.RegisterDate = DateTime.Now;

System.Console.WriteLine(nelson.ShowData());