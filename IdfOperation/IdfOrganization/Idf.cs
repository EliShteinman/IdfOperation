using IdfOperation.IdfOrganization.Commands.CombatUnits;
using IdfOperation.IdfOrganization.Commands.GroundForces.Soldiers;
using IdfOperation.Interfaces;

namespace IdfOperation.IdfOrganization;

public class Idf : Organization
{
    public List<StrikeUnit> StrikeUnits { get; set; }
    public List<IdfSoldier> IdfSoldiers { get; set; }

    public Idf(string name, IdfSoldier commander, DateTime date)
        : base(name, date, commander)
    {
        this.StrikeUnits = new List<StrikeUnit>();
        this.IdfSoldiers = new List<IdfSoldier>() { commander };
    }
}