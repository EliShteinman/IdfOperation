using IdfOperation.Forces;
using IdfOperation.Forces.Idf.CombatUnits;

namespace IdfOperation.Organization;

public class Idf : IOrganization
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public Soldier Commander { get; set; }
    private List<StrikeUnit> Soldiers;
}