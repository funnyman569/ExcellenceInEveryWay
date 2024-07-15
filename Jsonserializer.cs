using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
public class Create
{
    public void CreateWorker(string [] args)
    {
        Person person = new Person();
        {
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
        File.WriteAllText("jaonfile.json", jsonString);

    }  

    //Makes a List<Person> which contains a string of each entry in 'Jaon' File
    //Is used in other classes to ultimately find the info of the person who we are looking for
        public void MakePersonInfoList()
    {
        var worker = File.ReadAllText("jaonfile.json");
        List<Person>? people = JsonSerializer.Deserialize<List<Person>>(worker);

        if (people != null)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"{person.f_name} {person.l_name}");
            }
        }
        else
        {
            Console.WriteLine("Deserialization failed.");
        }
    }

   


    
        
}