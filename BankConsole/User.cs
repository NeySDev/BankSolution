namespace BankConsole;

public class User
{
    #region Properties
    private int Id { set; get; }
    private string Name { get; set; }
    private string Email { get; set; }
    private decimal Balance { get; set; }
    private DateTime RegisterDate { get; set; }
    #endregion

    #region Constructors
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
    #endregion

    #region Methods
    public string ShowData()
    {
        return $"=========================\nNombre: {this.Name}\nCorreo: {this.Email}\nSaldo: {this.Balance}\nFecha de registro: {this.RegisterDate}\n=========================\n";
    }

    public string ShowData(string message)
    {
        return $"=========================\n{message} \nNombre: {this.Name}\nCorreo: {this.Email}\nSaldo: {this.Balance}\nFecha de registro: {this.RegisterDate}\n=========================\n";
    }

    public void Deposit(decimal amount)
    {
        this.Balance += amount;
    }

    public void Charge(decimal amount)
    {
        if (this.Balance >= amount)
        {
            this.Balance -= amount;
        }
    }

    public void SetBalance(decimal amount)
    {
        decimal quantity = 0;

        if (amount < 0)
        {
            quantity = 0;
        }
        else
        {
            quantity = amount;
        }

        this.Balance += quantity;
    }
    #endregion
}