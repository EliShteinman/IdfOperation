using Lite.Core.Enum;
namespace Lite.Core.Forces.Idf;

public abstract class Drone : StrikeUnit
{
    protected Drone(string name, int ammunition, double fuel,  string[] targetTypes, BombType[] ordnanceType)
        : base(name, ammunition, fuel, targetTypes, ordnanceType)
    {

    }

}