using Lite.Core.Contracts;
using Lite.Core.Enum;

namespace Lite.Core.Forces.Idf;

public abstract class Plane : StrikeUnit
{
    public ISoldier Pilot { get; protected set; }
    protected Plane(string name, double fuel,  LocationType[] targetTypes, BombType[] ordnanceLoad, ISoldier pilot) : base(name, fuel, targetTypes, ordnanceLoad)
    {
        if (pilot.Assignment != Assignments.Pilot) throw new ArgumentException("Assignments must be Pilot");
        Pilot = pilot;
    }
}