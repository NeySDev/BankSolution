namespace BankConsole;

public class Employee : User, IPersona
{
    private string Department { set; get; }
    public Employee(int Id, string Name, string Email, decimal Balance, string Department) : base(Id, Name, Email, Balance)
    {
        this.Department = Department;
    }

    public override void SetBalance(decimal amount)
    {
        base.SetBalance(amount);

        if (!string.IsNullOrEmpty(Department))
        {
            if (Department.Equals("TI"))
                Balance += amount * 0.05m;
        }
    }

    public override string ShowData()
    {
        return base.ShowData() + $"\nDepartamento: {this.Department}";
    }

    public string GetName()
    {
        return Name;
    }

    public string GetCountry()
    {
        return "Veracruz";
    }
}