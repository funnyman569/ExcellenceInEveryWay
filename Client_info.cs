using System.Net.WebSockets;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Client_info: Person
{
    public List<string>? goals {get; set;} = new List<string>();
    
    public int time_allowed_with_BI { get; set; }
    public int time_allowed_with_PP { get; set; }

   
}

