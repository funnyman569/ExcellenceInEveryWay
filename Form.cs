using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
public class Form
{
    public void FillForm()
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

        var goalInfoList = new List<Dictionary<string, string>>();
        Create get_client = new(); // get client

        Client_info person = get_client.getClientInfo(c_firstName, c_lastName);
        if (person != null)
        {
            foreach (string goal in person.goals)
            {
                Console.WriteLine($"Goal: {goal}"); 
                Console.Write("How well did they do on this Goal [1-5]: ");
                string c_goalRating = Console.ReadLine();
                Console.WriteLine("Notes: ");
                string c_notes = Console.ReadLine();

                var goalInfo= new Dictionary<string, string>
                {
                    {"goal", goal},
                    {"goalRating", c_goalRating},
                    {"notes", c_notes}
                };

                goalInfoList.Add(goalInfo);
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
                ClientFirstName = c_firstName,
                ClientLastName = c_lastName,
                Goals = goalInfoList
            };

            string json = JsonConvert.SerializeObject(formData, Formatting.Indented);
            File.WriteAllText("Report.json", json);
            Console.WriteLine("Form data saved to Report.json");

    }
}