using BankConsole;

User nelson = new User();

nelson.Id = 1;
nelson.Name = "Nelson";
nelson.Email = "nelsonortiz102@gmail.com";
nelson.RegisterDate = DateTime.Now;

System.Console.WriteLine(nelson.ShowData());

User yureli = new User(2, "Yureli", "yureliortiz@gmail.com", 100);
System.Console.WriteLine(yureli.ShowData());