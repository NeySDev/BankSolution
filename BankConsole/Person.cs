namespace BankConsole;

public abstract class Person
{
    //Una clase abstracta puede tener: Metodos y propiedades abstractas, al igual que no tenerlas
    //public abstract int heigt { set; get; }

    //Los metodos ABSTRACTOS solo se DECLARA pero no se IMPLEMENTA.
    public abstract string GetName();

    //Este metodo se DECLARA Y IMPLEMENTA, se puede invocar en la clase que implemente la clase abstracta
    public string GetCountry()
    {
        return "México";
    }
}