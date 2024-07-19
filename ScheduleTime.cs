public class ScheduleTime : Scheduleing
{

    public void scheduleClientTime()
    {
        Client_info client = new Client_info();
        Worker workers = new();
        List<Worker> employees = workers.CreateInstanceofWorker();

        System.Console.WriteLine("Which client would you like to schedule for? \nPlease Type the first name, press enter, then Type the last name and press enter. ");
        try
        {
            Client_info person = client.getClientInfo(Console.ReadLine(), Console.ReadLine());
        }
        catch
        {
            System.Console.WriteLine("That person does not exit in the records. Please try again.");
        }

        Console.WriteLine("would you like to schedule a . . . \n1: Parah Professional \n2:Behavior Interventionist?\nType '1' or '2' ");
        
        string userSelection = Console.ReadLine();

        if (userSelection == "1")
        {   
            System.Console.WriteLine("You may schedule with . . .");
            foreach (Worker worker in employees)
            {
                if (worker.title == "Behavior Interventionist")
                {
        
                    System.Console.WriteLine($"{worker.f_name} {worker.l_name}");
                    string fname = worker.f_name;
                    System.Console.WriteLine("They are available today between . . .");
                    foreach (string time in worker.availability)
                    {
                        if (fname == worker.f_name)
                        {
                            System.Console.WriteLine(time);
                        }
                        
                    }
                }
            }
        }

        else if (userSelection == "2")
            {
                System.Console.WriteLine("You may schedule with . . .");
                foreach (Worker worker in employees)
                {
                    if (worker.title == "Behavior Interventionist")
                        {
                            System.Console.WriteLine($"{worker.f_name} {worker.l_name}");
                            string fname = worker.f_name;
                            System.Console.WriteLine("They are available today between . . .");
                            foreach (string time in worker.availability)
                            {
                                if (fname == worker.f_name)
                                {
                                    System.Console.WriteLine(time);
                                }
                            }
                    
                        }
                }
            }
            else
            {
                System.Console.WriteLine("Not a valid input. Probably should quit your job. ");
            }

        
        }
    }
