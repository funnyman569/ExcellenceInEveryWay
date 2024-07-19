using System.Net.WebSockets;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class Client_info: Person
{
    public List<string>? goals {get; set;} = new List<string>();
    public List<string>? Parents {get; set;} = new();
    public int time_allowed_with_BI { get; set; }
    public int time_allowed_with_PP { get; set; }

   public override string ToString()
    {
        var goalsStr = goals != null? string.Join(", ", goals) : "No goals";
        return $"Name: {f_name} {l_name}\nEmail: {email}\nPhone: {phoneNumber}\nGoals: {goalsStr}\nTime allowed with BI: {time_allowed_with_BI}\nTime allowed with PP: {time_allowed_with_PP}";
    }

     public Client_info? getClientInfo(string firstName, string lastName)
    {
        if(File.Exists("clientJsonFile.json"))
        {
            string jsonData = File.ReadAllText("clientJsonFile.json");
            List<Client_info>? client = JsonConvert.DeserializeObject<List<Client_info>>(jsonData);
            Client_info? person = client.FirstOrDefault(x => x.f_name == firstName && x.l_name == lastName);
            return person;
        }
        else
        {
            return null;
        }

    }

    public void SetClientParents()
    {
        bool exitKey = true;
        while (exitKey)
        {
            System.Console.WriteLine("Please Enter the First Gaurdians Name");
            string gaurdian = Console.ReadLine();
            Parents.Add(gaurdian);
            System.Console.WriteLine("Would you like to add another Gaurdian? (Y/N)");
            string add = Console.ReadLine().ToUpper();
            if (add == "N")
            {
                exitKey = false;
            }
        }
    }

    

    public List<string> GetClientParents()
    {
        return Parents;
    }
public void SetClientGoals()
    {
        bool exitKey = true;
        while (exitKey)
        {
            System.Console.WriteLine("Please List the first goal for this client.");
            string goal = Console.ReadLine();
            goals.Add(goal);
            System.Console.WriteLine("Would you like to add another goal? (Y/N)");
            string add = Console.ReadLine().ToUpper();
            if (add == "N")
            {
                exitKey = false;
            }
        }
    }

public List<string> GetClientGoals()
{
    return goals;
}
}


