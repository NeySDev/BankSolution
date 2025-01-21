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

        List<object> listUsers = JsonConvert.DeserializeObject<List<object>>(usersInFile);

        if (listUsers == null)
        {
            listUsers = new List<object>();
        }

        listUsers.Add(user);

        JsonSerializerSettings settings = new JsonSerializerSettings { Formatting = Formatting.Indented };

        string json = JsonConvert.SerializeObject(listUsers, settings);

        File.WriteAllText(filePath, json);
    }
}
