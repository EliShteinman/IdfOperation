namespace Lite.Domain.Forces.Idf;

public abstract class Drone : StrikeUnit
{
    protected Drone(string name, int ammunition, double fuel, int strikeLimit, string[] targetTypes)
        : base(name, ammunition, fuel, strikeLimit, targetTypes)
    {

    }

}