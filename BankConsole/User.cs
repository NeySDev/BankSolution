namespace BankConsole;

public class User
{
    public int ID { set; get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal Balance { get; set; }
    public DateTime RegisterDate { get; set; }

    public string ShowData()
    {
        return $"Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha de registro: {this.RegisterDate}";
    }
}