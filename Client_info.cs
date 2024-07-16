using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class Client_info: Person
{

    public List<string> goals { get; set; } = new List<string>();

    public Client_info? getClientInfo(string firstName, string lastName)
    {
        string jsonData = File.ReadAllText("clientJsonFile.json");
        List<Client_info>? client = JsonConvert.DeserializeObject<List<Client_info>>(jsonData);
        Client_info? person = client.FirstOrDefault(x => x.f_name == firstName && x.l_name == lastName);
        return person;
    }
}

