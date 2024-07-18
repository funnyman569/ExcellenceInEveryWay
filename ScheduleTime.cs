public class ScheduleTime : Scheduleing
{

    public void scheduleClientTime()
    {
        Client_info client = new Client_info();
        Client_info person = client.getClientInfo("Brayden", "Bold");

        Console.WriteLine($"The client is {person.ToString()}");

    }
}