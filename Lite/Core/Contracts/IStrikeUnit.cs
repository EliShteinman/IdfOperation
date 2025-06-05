using Lite.Core.Enum;
namespace Lite.Core.Contracts;

public interface IStrikeUnit : INamedEntity
{
    KnownLocationType[] TargetTypes { get; }
    int Ammunition { get; }
    double Fuel { get; }
    bool Strike();
    bool IsAvailableForStrike();
}
