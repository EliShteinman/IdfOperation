using Lite.Core.Enum;
namespace Lite.Core.Forces.Idf;

public abstract class Drone : StrikeUnit
{
    protected Drone(string name, double fuel, LocationType[] targetTypes, BombType[] ordnanceLoad)
        : base(name, fuel, targetTypes, ordnanceLoad)
    {

    }

}