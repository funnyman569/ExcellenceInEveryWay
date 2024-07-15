using System.Text.Json;
using System.Text.Json.Serialization;
public class Client_info: Person
{

    public List<string> goals = new List<string>();

    public void getClientInfo(string firstName, string lastName)
    {
        string jsonData = File.ReadAllText("clientJsonFile.js");
        List<Client_info> client = jsonConvert.DeserializeObject<List<Client_info>>(jsonData);
        Client_info person = client.FirstOrDefault(x => x.f_name == firstName && x.l_name == lastName);
    }
}