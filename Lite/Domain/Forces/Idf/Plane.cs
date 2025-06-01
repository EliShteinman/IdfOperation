using Lite.Domain.Contracts;
using Lite.Domain.Enum;

namespace Lite.Domain.Forces.Idf;

public abstract class Plane : StrikeUnit
{
    public ISoldier Pilot { get; protected set; }
    protected Plane(string name, int ammunition, double fuel, string[] targetTypes, int strikeLimit, ISoldier pilot) : base(name,
        targetTypes, ammunition, fuel, strikeLimit)
    {
        if (pilot.Assignment != Assignments.Pilot) throw new ArgumentException("Assignments must be Pilot");
        Pilot = pilot;
    }
}