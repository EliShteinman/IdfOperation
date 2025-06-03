namespace Lite.Domain.Forces.Idf;

public abstract class M109 : StrikeUnit
{
    public M109(string name, int ammunition, double fuel, int strikeLimit, string[] targetTypes)
        : base(name, ammunition, fuel, strikeLimit, targetTypes)
    {

    }

}