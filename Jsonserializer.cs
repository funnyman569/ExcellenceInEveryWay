using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
public class Create
{
    public void CreateWorker()
    {
        Worker worker = new();
        Scheduleing scheduleing = new();
        {
            Console.Write("Enter your first name: ");
            worker.f_name = Console.ReadLine();
            Console.Write("Enter your last name: ");
            worker.l_name = Console.ReadLine();
            Console.WriteLine("What is your email?");
            worker.email = Console.ReadLine();
            Console.WriteLine("Enter your title [Parah Professional / Behavior Interventionist]: ");
            worker.title = Console.ReadLine();
            Console.Write("Enter your agreed hourly pay: ");
            worker.hourly_pay = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            worker.phoneNumber = Console.ReadLine();
            scheduleing.SetAvailabilityBeginning();
            scheduleing.SetAvailabilityEnd();
            worker.availability = [$"{scheduleing.GetAvailabilityBeginning()} - {scheduleing.GetAvailabilityEnd()}"];
        }

        List<Worker> workers = new List<Worker>();

        if (File.Exists("jaonfile.json"))
        {
            string existingData = File.ReadAllText("jaonfile.json");
            if (!string.IsNullOrWhiteSpace(existingData))
            {
                try
                {
                    workers = System.Text.Json.JsonSerializer.Deserialize<List<Worker>>(existingData) ?? new List<Worker>();
                }
                catch (System.Text.Json.JsonException ex)
                {
                    Console.WriteLine($"Failed to deserialize existing JSON data: {ex.Message}");
                    workers = new List<Worker>();
                }
             }




        workers.Add(worker);

        var options = new JsonSerializerOptions { WriteIndented = true };
         string jsonString = System.Text.Json.JsonSerializer.Serialize(workers, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("jaonfile.json", jsonString);

        }  
    }

    public void CreateNewClient()
    {
            
        Client_info newClient = new();
        {
            System.Console.WriteLine("Enter the Clients First Name: ");
            newClient.f_name = Console.ReadLine();
            System.Console.WriteLine("Enter the Clients Last Name");
            newClient.l_name = Console.ReadLine();
            System.Console.WriteLine("What goals is there for this patient? ");
            newClient.SetClientGoals();
            newClient.goals = newClient.GetClientGoals();
            System.Console.WriteLine("What is the Clients email address?");
            newClient.email = Console.ReadLine();
            System.Console.WriteLine("What is the Clients phone number?");
            newClient.phoneNumber = Console.ReadLine();
            System.Console.WriteLine("What is the Clients legal gaurdian?");
            newClient.SetClientParents();
            newClient.Parents = newClient.GetClientParents();
            System.Console.WriteLine("How much time is this patient allowed with a Beahavioral Interventionist? ");
            newClient.time_allowed_with_BI = int.Parse(Console.ReadLine());
            System.Console.WriteLine("How much time is this patient allowed with a Parah Professional? ");
            newClient.time_allowed_with_PP = int.Parse(Console.ReadLine());
        }
    
        List<Client_info> clients = new();

    if (File.Exists("clientJsonFile.json"))
    {
        string existsData = File.ReadAllText("clientJsonFile.json");
        if(!string.IsNullOrWhiteSpace(existsData))
        {
            try
            {
                clients = System.Text.Json.JsonSerializer.Deserialize<List<Client_info>>(existsData) ?? new List<Client_info>();
            }
            catch (System.Text.Json.JsonException ex)
            {
                Console.WriteLine($"Failed to deserialize existing JSON data: {ex.Message}");
                    clients = new List<Client_info>();
            }

        }

        clients.Add(newClient);

        var options = new JsonSerializerOptions { WriteIndented = true };
         string jsonString = System.Text.Json.JsonSerializer.Serialize(clients, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("clientJsonFile.json", jsonString);
    }


    }

    //Makes a List<Worker> which contains a string of each entry in 'Jaon' File
    //Is used in other classes to ultimately find the info of the worker who we are looking for
        public List<Worker> MakeWorkerInfoList()
            {
                List<Worker> people = new();
                var workerObject = File.ReadAllText("jaonfile.json"); //workerObject holds the deserialized info of the worker
                return people = System.Text.Json.JsonSerializer.Deserialize<List<Worker>>(workerObject);
            } 
    
}