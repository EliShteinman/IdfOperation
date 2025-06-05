namespace Lite.Core.Forces.Idf;

public abstract class Artillery : StrikeUnit
{
    protected Artillery(string name, int ammunition, double fuel, int strikeLimit, string[] targetTypes)
        : base(name, ammunition, fuel, strikeLimit, targetTypes)
    {

    }
}