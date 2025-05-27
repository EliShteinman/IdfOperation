namespace IdfOperation.Forces.Idf.CombatUnits;

public abstract class Artillery : StrikeUnit
{
    protected Artillery(string name, int ammunition, double fuel, string[] targetTypes, int strikeLimit)
        : base(name, ammunition, fuel, targetTypes, strikeLimit)
    {

    }
}