namespace Lite.Core.Contracts;

public interface IStrikeUnit : INamedEntity
{
    string[] TargetTypes { get; }
    int Ammunition { get; }
    double Fuel { get; }
    bool Strike();
    bool IsAvailableForStrike();
}
