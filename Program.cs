

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Excellence in Every Way. Please choose an option.");
        Console.WriteLine("1. Fill out Form for the day.");
        Console.WriteLine("2. Schedule times for the day.");
        Console.WriteLine("3. Send form to insurance companies and gov");
        Console.WriteLine("4. Pay Emplayees");
        Console.WriteLine("5. Create new employee");
        Console.WriteLine("6. Create new client");
        Console.WriteLine("7. Exit");
        Console.Write("Pick a number between 1 and 5: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Form form = new();
            form.FillForm();
        }
        else if (choice == 2)
        {
            ScheduleTime scheduling = new();
            scheduling.scheduleClientTime();
        }
        else if (choice == 3)
        {
            SendForm sendForm = new();
            sendForm.SendDailyForm();
        }
        else if (choice == 4)
        {
            Pay pay = new();
           
            pay.CalculateAndPrintTotalPays();    
        }
        else if (choice == 5)
        {
            Create create = new();
            create.CreateWorker();            
        }
        else if (choice == 6)
        {
           Create create = new();
           create.CreateNewClient();
        }
        else if (choice == 7)
        {
            System.Console.WriteLine("Thanks for playing!");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            Main(args);
        }
    }
}


