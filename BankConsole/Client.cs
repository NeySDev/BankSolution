namespace BankConsole;

public class Client : User
{
    private char TaxRegime { set; get; }
    public Client(int Id, string Name, string Email, decimal Balance, char TaxRegime) : base(Id, Name, Email, Balance)
    {
        this.TaxRegime = TaxRegime;
    }

    public override void SetBalance(decimal amount)
    {
        base.SetBalance(amount);

        if (TaxRegime.Equals('M'))
            Balance += amount * 0.02m;
    }

    public override string ShowData()
    {
        return base.ShowData() + $"\nRegimen Fiscal: {this.TaxRegime}";
    }
}
