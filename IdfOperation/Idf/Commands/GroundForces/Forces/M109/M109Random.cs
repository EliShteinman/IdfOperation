using IdfOperation.Utils;

namespace IdfOperation.Idf.Commands.GroundForces.Forces.M109;

public class M109Random : M109
{
    public M109Random()
        : base(
            RandomGenerators.Serial.GetNext("M109"),
            RandomGenerators.SharedRandom.Next(41),
            RandomGenerators.SharedRandom.Next(41),
            RandomGenerators.SharedRandom.Next(41)
        )
    {

    }
}