
class Pay : Worker
{
    private string hourlyPay{get; set;}
    private int hoursWorked{get;}

    public Pay()
    {
        hoursWorked = 5;
    }

    public int SetTotalPay(int hourlyPay, int hoursWorked)
    {
       return hourlyPay * hoursWorked;
    }

public void PrintTotalPay()
{
    System.Console.WriteLine(SetTotalPay(int.Parse(hourlyPay), hoursWorked ));
}








}

