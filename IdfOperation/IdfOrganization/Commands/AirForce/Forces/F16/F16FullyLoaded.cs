using IdfOperation.IdfOrganization.Commands.GroundForces.Soldiers;
using IdfOperation.Utils;

namespace IdfOperation.IdfOrganization.Commands.AirForce.Forces.F16;

public class F16FullyLoaded : F16
{
    public F16FullyLoaded()
        : base(
            RandomGenerators.Serial.GetNext("F16"),
            8,
            8,
            8,
            new Pilot()
        )
    {

    }
}