namespace IdfOperation.Forces.Idf;

public class Artillery : IStrikeUnit
{
    public string Name { get; set; }
    public double Fuel { get; set; }
    public int Ammunition { get; set; }
    public string TargetType { get; set; }
    public int StrikeCycleLimit { get; set; }
    public bool Strike()
    {
        return true;
    }
}