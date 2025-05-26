namespace IdfOperation.Forces.Idf.CombatUnits;

public abstract class Drone : IStrikeUnit
{
    public string Name { get; set; }
    public double Fuel { get; set; }
    public int Ammunition { get; set; }
    public string TargetType { get; set; }
    public int StrikeCycleLimit { get; set; }

    public override bool Strike()
    {
        return true;
    }
}