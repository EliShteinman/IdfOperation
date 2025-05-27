namespace IdfOperation.Interfaces;

public interface IStrikeUnit
{
    int Ammunition { get; }
    double Fuel { get; }
    string[] TargetTypes { get; }
    int StrikeCycleLimit { get; }

    bool Strike();
    bool IsAvailableForStrike();
}