using IdfOperation.Utils;
using IdfOperation.Forces.Idf.Soldiers;

namespace IdfOperation.Forces.Idf.CombatUnits.F16;

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