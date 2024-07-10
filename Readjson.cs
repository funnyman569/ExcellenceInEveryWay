using System.IO
using System.Text.Json;

public class Person()
{
    public string f_name;
    public string l_name;
    public string title;
    public string email;
    public string phoneNumber;
    public List<string> goals = new List<string>();

    public Person() { 
        goals = new List<string>();
    }
}

public class ReadJson
{
    public static void Main()
    {
        string json = File.ReadAllText("jaonfile.js");
        Person person = JsonSerializer.Deserialize<Person>(json);
        Console.WriteLine(person.f_name);
    }
}

