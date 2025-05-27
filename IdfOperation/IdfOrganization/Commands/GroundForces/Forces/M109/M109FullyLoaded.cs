using IdfOperation.Utils;

namespace IdfOperation.IdfOrganization.Commands.GroundForces.Forces.M109;

public class M109FullyLoaded : M109
{
    public M109FullyLoaded()
        : base(
            RandomGenerators.Serial.GetNext("M109"),
            40,
            40,
            40
        )
    {

    }
}