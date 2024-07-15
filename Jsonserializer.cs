using System.Text.Json;
using System.Text.Json.Serialization;
public class Create
{
    public void CreateWorker(string [] args)
    {
        Person person = new Person();
        {
            //NOTE FROM HAYDEN: variable assignment doesnt need to be of variable type 'person'
            Console.Write("Enter your first name: ");
            person.f_name = Console.ReadLine();
            Console.Write("Enter your last name: ");
            person.l_name = Console.ReadLine();
            Console.WriteLine("Enter your title [Parah Professional / Behavior Interventionist]: ");
            person.title = Console.ReadLine();
            Console.Write("Enter your agreed hourly pay: ");
            person.hourly_pay = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            person.phoneNumber = Console.ReadLine();
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