namespace IdfOperation.Forces.Idf.CombatUnits;

public abstract class Artillery : StrikeUnit
{
    protected Artillery(string name, int ammunition, double fuel, string[] targetType, int strikeLimit)
        : base(name, ammunition, fuel, targetType, strikeLimit)
    {

    }
}