using Lite.Core.Combat;
using Lite.Core.Enum;
namespace Lite.Core.Contracts;

public interface IStrikeUnit : INamedEntity
{
    LocationType[] TargetTypes { get; }
    int Ammunition { get; }
    double Fuel { get; }
    StrikeResult Strike();
    bool IsAvailableForStrike();
}
