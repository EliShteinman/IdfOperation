using IdfOperation.Idf.Constants;

namespace IdfOperation.Idf.Commands.AirForce.Forces;

public abstract class Drone : StrikeUnit
{
    protected Drone(string name, int ammunition, double fuel, string[] targetTypes, int strikeLimit)

        : base(name, ammunition, fuel, targetTypes, strikeLimit)
    {

    }

}