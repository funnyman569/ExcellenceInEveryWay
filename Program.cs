/*
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
            Form();
        }
        else if (choice == 2)
        {
            ScheduleTimes();
        }
        else if (choice == 3)
        {
            SendForm();
        }
        else if (choice == 4)
        {
            PayEmployees();
        }
        else if (choice == 5)
        {

        }
        else if (choice == 6)
        {
            CreateNewClient();
        }
        else if (choice == 7)
        {
            Exit();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            Main(args);
        }
    }
}

*/

class Program
{
    static void Main(string[] args)
    {
        Client_info client_Info = new();
        client_Info.getClientInfo("Brayden", "Bold");
    }
}