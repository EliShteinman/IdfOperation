namespace Lite.Core.Contracts;

public interface IStrikeUnit : INamedEntity
{
    string[] TargetTypes { get; }
    int Ammunition { get; }
    double Fuel { get; }
    int StrikeCycleLimit { get; }
    bool Strike();
    bool IsAvailableForStrike();
}
