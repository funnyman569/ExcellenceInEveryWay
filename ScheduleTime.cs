public class ScheduleTime : Scheduleing
{

    public void scheduleClientTime()
    {
        Client_info client = new Client_info();
        Client_info person = client.getClientInfo("Brayden", "Bold");

        Console.WriteLine($"The client is {person.ToString()}");

        Console.WriteLine("would you like to schedule a 1: Parah Professional or 2:Behavior Interventionist?");
        Console.Write("1. Parah Professional\n2. Behavior Interventionist please enter 1 or 2");
        Console.ReadLine();
        if (Console.ReadLine() == "1")
        {
            string f_name = "Mike";
            string l_name = "Wazowsky";
        }
        else if (Console.ReadLine() == "2")
        {
            string f_name = "Han";
            string l_name = "Solo";
        }

        
    }
}