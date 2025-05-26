namespace IdfOperation.Forces.Idf.CombatUnits;

public abstract class M109 : Artillery
{
    public M109(string name, int ammunition, double fuel, int strikeLimit)
        : base(name, ammunition, fuel, "OpenArea", strikeLimit)
    {

    }
}