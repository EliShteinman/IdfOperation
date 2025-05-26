namespace IdfOperation.Forces.Idf.CombatUnits;

public abstract class Drone : StrikeUnit
{
    protected Drone(string name, int ammunition, double fuel, string[] targetType, int strikeLimit)
        : base(name, ammunition, fuel, targetType, strikeLimit)
    {

    }

}