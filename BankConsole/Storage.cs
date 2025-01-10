using Newtonsoft.Json;

namespace BankConsole;

public static class Storage
{
    static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");

    public static void AddUser(User user)
    {
        string usersInFile = "";

        if (File.Exists(filePath))
        {
            usersInFile = File.ReadAllText(filePath);
        }

        List<User> listUsers = JsonConvert.DeserializeObject<List<User>>(usersInFile);

        if (listUsers == null)
        {
            listUsers = new List<User>();
        }

        listUsers.Add(user);

        string json = JsonConvert.SerializeObject(listUsers);

        File.WriteAllText(filePath, json);
    }
}
