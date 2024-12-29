namespace BankConsole;

public class User
{
    public int Id { set; get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal Balance { get; set; }
    public DateTime RegisterDate { get; set; }

    public User()
    {
        this.Balance = 0;
    }

    public User(int Id, string Name, string Email, decimal Balance)
    {
        this.Id = Id;
        this.Name = Name;
        this.Email = Email;
        this.Balance = Balance;
        this.RegisterDate = DateTime.Now;
    }

    public string ShowData()
    {
        return $"=========================\nNombre: {this.Name}\nCorreo: {this.Email}\nSaldo: {this.Balance}\nFecha de registro: {this.RegisterDate}\n=========================\n";
    }
}