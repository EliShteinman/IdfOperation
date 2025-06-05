using Lite.Core.Contracts;
using Lite.Core.Enum;
namespace Lite.Core.Intelligence;

public class IntelligenceMessage
{
    public ITerrorist Target { get; private set; }
    public LocationType LastLocation { get; private set; }
    public DateTime LastSeen { get; private set; }
    public IntelligenceMessage(ITerrorist target, LocationType lastLocation, DateTime lastSeen)
    {
        Target = target;
        LastLocation = lastLocation;
        LastSeen = lastSeen;
    }
}