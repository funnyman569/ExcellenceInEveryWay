class Form
{
    public static Form()
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        console.WriteLine("Date: " + date);

        console.Write("Worker's First Name: ");
        string workerFirstName = console.ReadLine();

        console.Write("Worker's Last Name: ");
        string workerLastName = console.ReadLine();

        console.write("JobTitle: ");
        string jobTitle = console.ReadLine();

        console.Write("StartTime: ");
        string startTime = console.ReadLine();

        console.Write("EndTime: ");
        string endTime = console.ReadLine();

        console.Write("Total Hours: ");
        string totalHours = console.ReadLine();

        console.WriteLine("Client Info: ");
        console.Write("First Name: ");
        string c_firstName = console.ReadLine();

        console.Write("Last Name: ");
        string c_lastName = console.ReadLine();

        var goalInfoList = new List<GoalInfo>();

        Client_info client = new Client_info();
        client.getClientInfo(c_firstName, c_lastName);
        if (client != null)
        {
            foreach (string goal in client.goals)
            {
                console.WriteLine($"Goal: {goal}"); 
                console.Write("How well did they do on this Goal [1-5]: ")
                string c_goalRating = console.ReadLine();
                console.WriteLine("Notes: ");
                string c_notes = console.ReadLine();

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
            console.WriteLine("Client not found");
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