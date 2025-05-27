using IdfOperation.IdfOrganization.Commands.CombatUnits;
using IdfOperation.IdfOrganization.Commands.GroundForces.Soldiers;

namespace IdfOperation.IdfOrganization.Commands.AirForce.Forces;

public abstract class Plane : StrikeUnit
{
    public IdfSoldier Pilot { get; protected set; }

    protected Plane(string name, int ammunition, double fuel, string[] targetTypes, int strikeLimit, IdfSoldier pilot)

        : base(name, ammunition, fuel, targetTypes, strikeLimit)
    {
        this.Pilot = pilot;
    }

}