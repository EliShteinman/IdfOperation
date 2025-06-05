using Lite.Core.Contracts;
using Lite.Core.Enum;

namespace Lite.Core.Forces.Idf;

public abstract class Plane : StrikeUnit
{
    public ISoldier Pilot { get; protected set; }
    protected Plane(string name, int ammunition, double fuel, int strikeLimit, string[] targetTypes, ISoldier pilot) : base(name,
         ammunition, fuel, strikeLimit, targetTypes)
    {
        if (pilot.Assignment != Assignments.Pilot) throw new ArgumentException("Assignments must be Pilot");
        Pilot = pilot;
    }
}