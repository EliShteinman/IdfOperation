using IdfOperation.IdfOrganization.Commands.Soldiers;
using IdfOperation.Utils;

namespace IdfOperation.IdfOrganization.Commands.AirForce.Forces.F16;

public class F16Random : F16
{
    public F16Random()
        : base(
            RandomGenerators.Serial.GetNext("F16"),
            RandomGenerators.SharedRandom.Next(9),
            RandomGenerators.SharedRandom.Next(9),
            RandomGenerators.SharedRandom.Next(9),
            new Pilot()
            )
    {

    }
}