//NOTE: This class sets job title by default. It does not reference Json. 
//Boolean logic will need to be used and checked against Json for referencing
class BehaviorInerventionist : Worker
{
    private string _jobTitle{get;};
    public BehaviorInterventionist() : base()
    {
        _jobTitle = "Behavior Interventiontionist";
    }

}