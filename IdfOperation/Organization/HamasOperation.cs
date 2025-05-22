using IdfOperation.Forces;
namespace IdfOperation;

public class HamasOperation: Organization
{
    public string Name {get; set;}
    public DateTime Date {get; set;}
    public ISoldier Commander {get; set;}
    private List<ITerrorist> Terrorists;
}