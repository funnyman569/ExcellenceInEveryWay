 //temporarily added "title" and "hourly_pay" inorder to test JsonSerializer
 public class Person
{
   public string? f_name { get; set; }
    public string? l_name { get; set; }
    public string? email { get; set; }
    public string? phoneNumber { get; set; }
    public string? title{get; set;}
    public string? hourly_pay{get; set;}
    public List<string>? goals { get; set; } = new List<string>();

}


