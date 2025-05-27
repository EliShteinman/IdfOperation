using IdfOperation.Utils;

namespace IdfOperation.IdfOrganization.Commands.AirForce.Forces.Hermes460;

public class Hermes460FullyLoaded : Hermes460
{
    public Hermes460FullyLoaded()
        : base(
            RandomGenerators.Serial.GetNext("Hermes460"),
            3,
            3,
            3
        )
    {

    }
}