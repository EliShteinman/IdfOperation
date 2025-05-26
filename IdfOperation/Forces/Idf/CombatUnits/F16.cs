using IdfOperation.Forces.Idf.Soldiers;

namespace IdfOperation.Forces.Idf.CombatUnits;

public abstract class F16 : Plane
{
    public F16(string name, int ammunition, double fuel, int strikeLimit, IdfSoldier pilot)
        : base(name, ammunition, fuel, "Buildings", strikeLimit, pilot)
    {

    }
}