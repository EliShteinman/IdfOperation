using Lite.Core.Contracts;
using Lite.Core.Enum;

namespace Lite.Core.Forces.Idf;

public abstract class Plane : StrikeUnit
{
    public ISoldier Pilot { get; protected set; }
    protected Plane(string name, int ammunition, double fuel,  string[] targetTypes, BombType ordnanceType, ISoldier pilot) : base(name,
         ammunition, fuel, targetTypes, ordnanceType)
    {
        if (pilot.Assignment != Assignments.Pilot) throw new ArgumentException("Assignments must be Pilot");
        Pilot = pilot;
    }
}