using System.Text.Json;
using System.Text.Json.Serialization;
public class Create
{
    public void CreateWorker(string [] args)
    {
        Person person = new Person();
        {
            console.Write("Enter your first name: ");
            person.f_name = console.ReadLine();
            console.Write("Enter your last name: ");
            person.l_name = console.ReadLine();
            console.WriteLine("Enter your title [Parah Professional / Behavior Interventionist]: ");
            person.title = console.ReadLine();
            console.Write("Enter your agreed hourly pay: ");
            person.hourly_pay = console.ReadLine();
            console.Write("Enter your phone number: ");
            person.phoneNumber = console.ReadLine();
        }

        string jsonString = JsonSerializer.Serialize(person);
        File.WriteAllText("jaonfile.js", jsonString);

    }

    public GetPerson_info()
    {
        var worker = File.ReadAllText("jaonfile.js");
        Person person = jsonSerializer.Deserialize<Person>(worker);
    }
        
}