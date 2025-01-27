using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

    public static List<User> GetNewUser()
    {
        string usersInFile = "";
        List<User> listUsers = new List<User>();

        if (File.Exists(filePath))
        {
            usersInFile = File.ReadAllText(filePath);
        }

        List<object> listObjects = JsonConvert.DeserializeObject<List<object>>(usersInFile);

        if (listObjects == null)
        {
            return listUsers;
        }

        foreach (object obj in listObjects)
        {
            User newUser;
            JObject user = (JObject)obj;

            if (user.ContainsKey("TaxRegime"))
            {
                newUser = user.ToObject<Client>();
            }
            else
            {
                newUser = user.ToObject<Employee>();
            }

            listUsers.Add(newUser);
        }

        var newUserslist = listUsers.Where(user => user.GetRegisterDate().Date.Equals(DateTime.Today)).ToList();

        return newUserslist;
    }
}
