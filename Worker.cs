
public class Worker : Person
{
    Create create = new();
    public string? title{get; set;}
    public string? hourly_pay{get; set;}

    public List<Worker> CreateInstanceofWorker()
    {
        return create.MakeWorkerInfoList();
    }
}