using System;

class Form
{
    public Form()
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Console.WriteLine("Date: " + date);

        Console.Write("Worker's First Name: ");
        string workerFirstName = Console.ReadLine();

        Console.Write("Worker's Last Name: ");
        string workerLastName = Console.ReadLine();

        Console.Write("JobTitle: ");
        string jobTitle = Console.ReadLine();

        Console.Write("StartTime: ");
        string startTime = Console.ReadLine();

        Console.Write("EndTime: ");
        string endTime = Console.ReadLine();

        Console.Write("Total Hours: ");
        string totalHours = Console.ReadLine();

        Console.WriteLine("Client Info: ");
        Console.Write("First Name: ");
        string c_firstName = Console.ReadLine();

        Console.Write("Last Name: ");
        string c_lastName = Console.ReadLine();

        var goalInfoList = new List<GoalInfo>();

        Client_info client = new Client_info();
        client.getClientInfo(c_firstName, c_lastName);
        if (client != null)
        {
            foreach (string goal in client.goals)
            {
                Console.WriteLine($"Goal: {goal}"); 
                Console.Write("How well did they do on this Goal [1-5]: ")
                string c_goalRating = Console.ReadLine();
                Console.WriteLine("Notes: ");
                string c_notes = Console.ReadLine();

                goalInfoList.Add(new GoalInfo
                {
                    goal = goal,
                    goalRating = c_goalRating,
                    notes = c_notes
                });
            }
        }
        else
        {
            Console.WriteLine("Client not found");
        }

        var formData = new
            {
                Date = date,
                WorkerFirstName = workerFirstName,
                WorkerLastName = workerLastName,
                JobTitle = jobTitle,
                StartTime = startTime,
                EndTime = endTime,
                TotalHours = totalHours,
                ClientFirstName = clientFirstName,
                ClientLastName = clientLastName,
                Goals = goalInfoList
            };

            string json = JsonConvert.SerializeObject(formData, Formatting.Indented);
            File.WriteAllText("Report.json", json);
            Console.WriteLine("Form data saved to formData.json");

    }
}