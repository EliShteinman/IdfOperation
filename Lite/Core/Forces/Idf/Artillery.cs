using Lite.Core.Enum;
namespace Lite.Core.Forces.Idf;

public abstract class Artillery : StrikeUnit
{
    protected Artillery(string name, int ammunition, double fuel,  KnownLocationType[] targetTypes, BombType[] ordnanceType)
        : base(name, ammunition, fuel, targetTypes, ordnanceType)
    {

    }
}