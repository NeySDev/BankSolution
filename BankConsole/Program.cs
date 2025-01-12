﻿using BankConsole;

// ********************
// CLASES
// User nelson = new User(1, "Nelson", "nelsonortiz102@gmail.com", 100);
// Console.WriteLine(nelson.ShowData());
// nelson.Deposit(1000);
// System.Console.WriteLine(nelson.ShowData());

// *********************
// SOBRECARGA
// nelson.Charge(2000);
// System.Console.WriteLine(nelson.ShowData("NO SE PUDO REALIZAR LA OPERACION"));


// *********************
// STATIC
// Storage.AddUser(nelson);
// User yureli = new User(2, "Yureli", "yureliortiz@gmail.com", 100);
// Storage.AddUser(yureli);

// ************************
// HERENCIA
Client alexa = new Client(3, "Alexa", "alexasoriano@gmail.com", 500, 'M');
System.Console.WriteLine(alexa.ShowData());
alexa.SetBalance(100);
System.Console.WriteLine(alexa.ShowData());

Employee oscar = new Employee(4, "Oscar", "oscarOrtiz@gmail.com", 1000, "TI");
oscar.SetBalance(500);
System.Console.WriteLine(oscar.ShowData());
