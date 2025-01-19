namespace BankConsole;

public interface IPersona
{
    // PROPIEDADES Y METODOS son todos abstractos, se deben DECLARAR pero no IMPLEMENTAR
    //int edad { set; get; }
    string GetName();
    string GetCountry();
}