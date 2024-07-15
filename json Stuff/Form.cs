class Form
{
    public static Form()
    {
        string date = console.WriteLine("Date: " + DateTime.Now);
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
        Client_info client = new Client_info();
        client.getClientInfo(c_firstName, c_lastName);
        foreach (string goal in client.goals)
        {
            console.WriteLine($"Goal: {goal}"); 
            console.Write("How good did they do this Goal [1-5]: ")
            string c_goalRating = console.ReadLine();
            console.WriteLine("Notes: ");
            string c_notes = console.ReadLine();
        }



    }
}