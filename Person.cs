public class Person()
{
    Jsonserializer jsonSerializer = new();
    public string f_name {get;};
    public string l_name {get;};
    public string email {get;};
    public string phoneNumber {get;};
    public List<string> goals = new List<string>();

    public Person() 
    { 
        f_name = "No Name";
        l_name = "No Name";
        email = "No Email";
        phoneNumber = "No phone number";
        goals = new List<string>();
    }
//need to fix the object reference issue that will arrise from referencing the list from the persons class in 
    public string SetFirstName();
    {
        f_name = jsonSerializer.GetPerson_info[1][0];
    }

    public string SetLastName();
    {
        l_name = jsonSerializer.METHODNAME[NUMBERINLIST];
    }

    public string SetEmail();
    {
        email =jsonSerializer.METHODNAME[NUMBERINLIST];
    }

    public string SetPhoneNumer();
    {
        phoneNumer = jsonSerializer.METHODNAME[NUMBERINLIST];
    }
}
