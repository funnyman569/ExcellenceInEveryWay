
public class Scheduleing
{
    protected Worker worker = new(); //use to set availabilities of workers
    protected Client_info client_Info = new(); //use to set availabilites of clients
    private string startTime;
    private string endTime;
    

    public Scheduleing()
    {
        
    }

    public void SetAvailabilityBeginning()
    {
        System.Console.WriteLine("What times are you available to begin a session?");
        System.Console.WriteLine("8:00\n9:00\n10:00\n11:00\n12:00\n1:00\n2:00\n3:00");
        string availability1 = Console.ReadLine();
        startTime = $"{availability1}:00" ;
    }

    public string GetAvailabilityBeginning()
    {
        return startTime;
    }

    public void SetAvailabilityEnd()
    {
        System.Console.WriteLine("Until what time are you available? ");
        string availability2 = Console.ReadLine();
        endTime = $"{availability2}:00";
    }

    public string GetAvailabilityEnd()
    {
        return endTime;
    }

    


    
}
