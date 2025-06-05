using Lite.Core.Enum;
namespace Lite.Core.Forces.Idf;

public abstract class Artillery : StrikeUnit
{
    protected Artillery(string name, double fuel, LocationType[] targetTypes, BombType[] ordnanceLoad)
        : base(name, fuel, targetTypes, ordnanceLoad)
    {

    }
}