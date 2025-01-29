using BankConsole;

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
// HERENCIA / POLIMORFISMO
// Client alexa = new Client(3, "Alexa", "alexasoriano@gmail.com", 500, 'M');
// System.Console.WriteLine(alexa.ShowData());
// alexa.SetBalance(100);
// System.Console.WriteLine(alexa.ShowData());

// Employee oscar = new Employee(4, "Oscar", "oscarOrtiz@gmail.com", 1000, "TI");
// oscar.SetBalance(500);
// System.Console.WriteLine(oscar.ShowData());

// ************************
// USO DE CLASE ABSTRACTA
// Client alexa = new Client(3, "Alexa", "alexasoriano@gmail.com", 500, 'M');
// System.Console.WriteLine(alexa.ShowData());
// alexa.SetBalance(100);
// System.Console.WriteLine(alexa.ShowData());
// System.Console.WriteLine("Bienvenida de nuevo: " + alexa.GetName());

// ************************
// CAMBIOS EN EL PROYECTO
// User nelson = new User(1, "Nelson", "nelsonortiz102@gmail.com", 100);
// Employee yureli = new Employee(2, "Yureli", "yureliortiz@gmail.com", 100, "TI");
// Client alexa = new Client(3, "Alexa", "alexasoriano@gmail.com", 500, 'M');

// Storage.AddUser(nelson);
// Storage.AddUser(yureli);
// Storage.AddUser(alexa);

// *************************
// ARGUMENTOS DE LA APLICACION
// if (args.Length == 0)
// {
//     System.Console.WriteLine("Enviar correo ...");
// }
// else
// {
//     System.Console.WriteLine($"Argumentos: {args[0]} , {args[1]} , {args[2]}");
// }

// ************************
// OBTENER OBJETOS DE ARCHIVO JSON
// Client ana = new Client(4, "Ana Maria", "algo@gmail.com", 100, 'M');
// Storage.AddUser(ana);
// Employee norma = new Employee(5, "Norma Leal", "algo2@gmail.com", 200, "Administración");
// Storage.AddUser(norma);
// foreach (var user in Storage.GetNewUser())
// {
//     System.Console.WriteLine(user.ShowData());
// }

// *********************
// ENVIAR CORREO
// if (args.Length == 0)
// {
//     EmailService.SendMail();
//     System.Console.WriteLine("Correo enviado.");
// }
// else
// {
//     System.Console.WriteLine("En mantenimiento: 404");
// }

// **********************
// AGREGAR USUARIOS VIA TERMINAL
if (args.Length == 0)
{
    EmailService.SendMail();
}
else
{
    ShowMenu();
}

static void ShowMenu()
{
    try
    {
        System.Console.Clear(); 
        System.Console.WriteLine("Selecciona una opción:");
        System.Console.WriteLine("1 - Crear un Usuario nuevo.");
        System.Console.WriteLine("2 - Eliminar un Usuario existente.");
        System.Console.WriteLine("3 - Salir.");

        int option = 0;

        do
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out option))
            {
                System.Console.WriteLine("Debes ingresar un número (1, 2 o 3).");
            }
            else if (option > 3)
            {
                System.Console.WriteLine("Debes ingresar un número (1, 2 o 3).");
            }

        } while (option == 0 || option > 3);

        switch (option)
        {
            case 1:
                CreateUser();
                break;
            case 2:
                DeleteUser();
                break;
            default:
                Environment.Exit(0);
                break;
        }
    }
    catch (System.IO.IOException ex)
    {
        System.Console.WriteLine("Error al limpiar la consola: " + ex.Message);
    }

    Thread.Sleep(2000);
    ShowMenu();
}

static void CreateUser()
{
    System.Console.Clear();
    System.Console.WriteLine("Ingresa la información del usuario:");

    System.Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());

    System.Console.Write("Nombre: ");
    string name = Console.ReadLine();

    System.Console.Write("Email: ");
    string email = Console.ReadLine();

    System.Console.Write("Saldo: ");
    decimal balance = decimal.Parse(Console.ReadLine());

    System.Console.Write("Escribe: 'c' si el usuario es Cliente, 'e' si es Empleado: ");
    char userType = char.Parse(Console.ReadLine());

    User newUser;
    if (userType.Equals('c'))
    {
        System.Console.Write("Regimen Fiscal: ");
        char taxRegime = char.Parse(Console.ReadLine());

        newUser = new Client(id, name, email, balance, taxRegime);
    }
    else
    {
        System.Console.Write("Departamento: ");
        string department = Console.ReadLine();

        newUser = new Employee(id, name, email, balance, department);
    }

    Storage.AddUser(newUser);

    System.Console.WriteLine("Usuario creado.");
    Thread.Sleep(2000);
    ShowMenu();
}

static void DeleteUser()
{
    System.Console.Clear();
    System.Console.Write("Ingrese el ID usuario a eliminar:");

    int id = int.Parse(Console.ReadLine());

    string result = Storage.DeleteUser(id);

    if (result.Equals("Success"))
    {
        System.Console.WriteLine("Usuario eliminado");
    }
    else
    {
        System.Console.WriteLine(result);
    }

    Thread.Sleep(2000);
    ShowMenu();
}