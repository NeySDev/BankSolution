using Newtonsoft.Json;

namespace BankConsole;

public class User
{
    #region Properties
    [JsonProperty]
    protected int Id { set; get; }
    [JsonProperty]
    protected string Name { get; set; }
    [JsonProperty]
    protected string Email { get; set; }
    [JsonProperty]
    protected decimal Balance { get; set; }
    [JsonProperty]
    protected DateTime RegisterDate { get; set; }
    #endregion

    #region Constructors
    public User()
    {

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
    public virtual string ShowData()
    {
        return $"\n======================================\nID: {this.Id} \nNombre: {this.Name}\nCorreo: {this.Email}\nSaldo: {this.Balance}\nFecha de registro: {this.RegisterDate.ToShortDateString()}";
    }

    public string ShowData(string message)
    {
        return $"\n======================================\n{message} \nNombre: {this.Name}\nCorreo: {this.Email}\nSaldo: {this.Balance}\nFecha de registro: {this.RegisterDate}";
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

    public virtual void SetBalance(decimal amount)
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

        Deposit(quantity);
    }

    public DateTime GetRegisterDate()
    {
        return RegisterDate;
    }

    public int GetID()
    {
        return Id;
    }
    #endregion
}