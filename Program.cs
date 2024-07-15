class Program
{
    static void Main(string[] args)
    {
        console.WriteLine("Welcome to the Excellence in Every Way. Please choose an option.");
        console.WriteLine("1. Fill out Form for the day.");
        console.WriteLine("2. Schedule times for the day.");
        console.WriteLine("3. Send form to insurance companies and gov");
        console.WriteLine("4. Pay Emplayees");
        console.WriteLine("5. Create new employee");
        console.writelie("6. Create new client");
        console.WriteLine("7. Exit");
        console.Write("Pick a number between 1 and 5: ");
        int choice = int.Parse(console.ReadLine());

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
            console.WriteLine("Invalid choice.");
            Main(args);
        }
    }
}
