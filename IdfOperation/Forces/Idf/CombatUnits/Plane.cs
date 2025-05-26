using IdfOperation.Forces.Idf.Soldiers;

namespace IdfOperation.Forces.Idf.CombatUnits;

public abstract class Plane : StrikeUnit
{
    public IdfSoldier Pilot { get; protected set; }
    protected Plane(string name, int ammunition, double fuel, string[] targetType, int strikeLimit, IdfSoldier pilot)
        : base(name, ammunition, fuel, targetType, strikeLimit)
    {
        this.Pilot = pilot;
    }



}