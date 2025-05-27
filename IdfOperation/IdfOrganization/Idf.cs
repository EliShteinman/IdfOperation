using IdfOperation.IdfOrganization.Commands.GroundForces.Soldiers;
using IdfOperation.Interfaces;

namespace IdfOperation.IdfOrganization;

public class Idf : IOrganization
{
    public string Name { get; private set; }
    public DateTime Date { get; private set; }
    public Soldier Commander { get; private set; }
    
    
    public List<StrikeUnit> StrikeUnits { get; set; }
    public List<IdfSoldier> IdfSoldiers { get; set; }

    public Idf(string name, IdfSoldier commander, DateTime date)
    {
        Name = name;
        Date = date;
        Commander = commander;

        StrikeUnits = new List<StrikeUnit>();
        IdfSoldiers = new List<IdfSoldier>() { commander };
    }
}