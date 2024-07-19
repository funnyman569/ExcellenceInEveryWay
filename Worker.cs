
public class Worker : Person
{
    Create create = new();
    public string? title{get; set;}
    public string? hourly_pay{get; set;}

    public List<Worker> CreateInstanceofWorker()
    {
        return create.MakeWorkerInfoList();
    }

     public override string ToString()
        {
            var availabilityStr = availability != null ? string.Join(", ", availability) : "No availability";

            return $"Title: {title}\n" +
                $"Hourly Pay: {hourly_pay}\n" +
                $"Name: {f_name} {l_name}\n" +
                $"Email: {email}\n" +
                $"Phone: {phoneNumber}\n" +
                $"Availability: {availabilityStr}";
        }
}