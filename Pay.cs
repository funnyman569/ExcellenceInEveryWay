
class Pay : Worker
{
    private int hourlyPay{get; set;}
    private int hoursWorked;
    private int totalPay;
     List<Worker> listOfWorkers = new();

    public Pay() : base()
    {   
        hoursWorked = 0;
        totalPay = 0;
        hourlyPay = 0;
    }

    public void CalculateAndPrintTotalPays()
    {
        listOfWorkers = CreateInstanceofWorker();
        foreach (Worker person in listOfWorkers)
        {
            System.Console.WriteLine($"How many hours did {person.f_name} work?");
            SetHoursWorked(int.Parse(Console.ReadLine()));
            if (int.TryParse(person.hourly_pay, out int parsedHourlyPay))
            {
                SetTotalPay(parsedHourlyPay, hoursWorked);
                 Console.WriteLine($"Total Pay for {person.f_name} {person.l_name}: {GetTotalPay()}");
            }
            
        }
    }

    public void SetHoursWorked(int HoursWorked)
    {
        hoursWorked = HoursWorked;
    }
    public int GetHourlyPay()
    {
        return hourlyPay;
    }

    public int GetHoursWorked()
    {
        return hoursWorked;
    }
    public void SetTotalPay(int hourlyPay, int hoursWorked)
    {
       totalPay = hourlyPay * hoursWorked;
    }

    public int GetTotalPay()
    {
        return totalPay;
    }








}

