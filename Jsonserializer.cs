using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
public class Create
{
    public void CreateWorker(string [] args)
    {
        Worker worker = new();
        {
            Console.Write("Enter your first name: ");
            worker.f_name = Console.ReadLine();
            Console.Write("Enter your last name: ");
            worker.l_name = Console.ReadLine();
            Console.WriteLine("Enter your title [Parah Professional / Behavior Interventionist]: ");
            worker.title = Console.ReadLine();
            Console.Write("Enter your agreed hourly pay: ");
            worker.hourly_pay = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            worker.phoneNumber = Console.ReadLine();
        }

        string jsonString = System.Text.Json.JsonSerializer.Serialize(worker);
        File.WriteAllText("jaonfile.json", jsonString);

    }  

    //Makes a List<Worker> which contains a string of each entry in 'Jaon' File
    //Is used in other classes to ultimately find the info of the worker who we are looking for
        public void MakeWorkerInfoList()
    {
        var workerObject = File.ReadAllText("jaonfile.json"); //workerObject holds the deserialized info of the worker
        List<Worker>? people = System.Text.Json.JsonSerializer.Deserialize<List<Worker>>(workerObject);
    }

     public static Client_info getClientInfo(string firstName, string lastName)
    {
        string jsonData = File.ReadAllText("clientJsonFile.json");
        List<Client_info>? client = JsonConvert.DeserializeObject<List<Client_info>>(jsonData);
        Client_info? person = client.FirstOrDefault(x => (x.f_name == firstName && x.l_name == lastName));
        return person;
    }
   


    
        
}