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
         Client_info client = new Client_info();

        System.Console.WriteLine("Which client would you like to schedule for? \nPlease Type the first name, press enter, then Type the last name and press enter. ");
        try
        {
            Client_info person = client.getClientInfo(Console.ReadLine(), Console.ReadLine());
        }
        catch
        {
            System.Console.WriteLine("That person does not exit in the records. Please try again.");
        }

        List<string> goalInfoList = new List<string>();

        foreach (var goal in client.goals)
        {
            string inputGoal = $"Goal:{goal}";
            Console.WriteLine( $"{inputGoal}");

            string qGoalRating = "How well did they do on their goal from 1 to 5: ";
            Console.Write(qGoalRating);
            string goalRating = Console.ReadLine();
            goalInfoList.Add(inputGoal);
            goalInfoList.Add(qGoalRating);
            goalInfoList.Add(goalRating);

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
                ClientFirstName = client.f_name,
                ClientLastName = client.l_name,
                Goals = goalInfoList
            };

            string json = JsonConvert.SerializeObject(formData, Formatting.Indented);
            File.WriteAllText("Report.json", json);
            Console.WriteLine("Form data saved to Report.json");

    }
}