using IdfOperation.Forces;
using IdfOperation.Forces.Idf;

namespace IdfOperation.Organization;

public class Idf : Organization
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public ISoldier Commander { get; set; }
    private List<IStrikeUnit> Soldiers;
}