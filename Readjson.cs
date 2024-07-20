using System.IO;
using System.Text.Json;

public class ReadJson
{
    public static void Read()
    {
        string json = File.ReadAllText("jaonfile.js");
        
    }

    public string ReadSubmittedJson()
    {
        string json = File.ReadAllText("Report.json");
        return json;
    }
}

