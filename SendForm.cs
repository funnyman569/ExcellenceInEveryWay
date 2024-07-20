class SendForm
{
    public void SendDailyForm()
    {
        List<string> forms = new List<string>();
        List<string> submitList = new List<string>();
        ReadJson report = new ReadJson();
        int choice = 0;
        do{
            string allforms = report.ReadSubmittedJson();
            Console.WriteLine("Would you like to submit 1, 2 or 3?");
            Console.WriteLine("1. Behavior Interventionist");
            Console.WriteLine("2. Parah Professional");
            Console.WriteLine("3. Both");
            Console.WriteLine("Please Enter a number: ");
            choice = int.Parse(Console.ReadLine());
        }
        while (choice != 1 && choice != 2 && choice != 3);

        if (choice == 1)
        {
            foreach (string form in forms)
            {
                if (form == "Behavior Interventionist")
                {
                    submitList.Add(form);
                }
            }
        }
        else if (choice == 2)
        {
            foreach (string form in forms)
            {
                if (form == "Parah Professional")
                {
                    submitList.Add(form);
                }
            }
        }
        else if (choice == 3)
        {
            foreach (string form in forms)
            {
                submitList.Add(form);
            }
        }

        foreach (string form in submitList)
        {   
            Console.WriteLine(form);
        }
        Console.WriteLine("Form has been sent");
    }



}
