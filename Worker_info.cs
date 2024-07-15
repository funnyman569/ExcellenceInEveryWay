public class Worker_info : Person
{
    string _title = {get; set};
    int _hourlyPay = {get; set};
}

getWorkerInfo(firstName, lastName)
{
    string json = File.ReadAllText("jaonfile.js");
    List<Worker_info> people = jsonConvert.DeserializeObject<List<Worker_info>>(jsonData);
    Worker_info person = people.FirstOrDefault(x => x.f_name == firstName && x.l_name == lastName);
}