using IdfOperation.Forces;

namespace IdfOperation;

public class IdfOperation : Organization
{
    public string Name {get; set;}
    public DateTime Date {get; set;}
    public ISoldier Commander {get; set;}
    private List<IStrikeUnit> Soldiers;
}