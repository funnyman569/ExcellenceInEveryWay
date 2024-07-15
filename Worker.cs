class Worker : Person
{
    Jsonserializer jsonSerializer = new();
    private string _hourlyPay {get:};
    public Worker() : base()
    {
        _hourlyPay = "No pay inputed";
    }
    
    //NEED TO UPDATE WITH CORRECT NAMES
    public int SetHourlyPay()
    {
       _hourlyPay = int.Parse(jsonSerializer.METHODNAME[NUMBERINLIST]);
    }
    
}