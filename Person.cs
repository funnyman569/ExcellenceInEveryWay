public class Person()
{
    public string f_name { get; set; };
    public string l_name { get; set; };
    public string title { get; set; };
    public string email { get; set; };
    public string phoneNumber { get; set; };
    public List<string> goals = new List<string>();

    public Person() { 
        goals = new List<string>();
    }
}