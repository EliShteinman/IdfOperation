using IdfOperation.Idf.Constants;

namespace IdfOperation.Idf.Commands.AirForce.Forces;

public abstract class Plane : StrikeUnit
{
    public IdfSoldier Pilot { get; protected set; }

    protected Plane(string name, int ammunition, double fuel, string[] targetTypes, int strikeLimit, IdfSoldier pilot)

        : base(name, ammunition, fuel, targetTypes, strikeLimit)
    {
        this.Pilot = pilot;
    }

}