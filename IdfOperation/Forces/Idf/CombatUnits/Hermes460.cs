namespace IdfOperation.Forces.Idf.CombatUnits;

public abstract class Hermes460 : Drone
{
    public Hermes460(string name, int ammunition, double fuel, int strikeLimit)
        : base(name, ammunition, fuel, "People / Vehicles", strikeLimit)
    {
    }
}