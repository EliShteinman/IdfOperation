using IdfOperation.Forces.Idf.Soldiers;
using IdfOperation.Utils;

namespace IdfOperation.Forces.Idf.CombatUnits.F16;

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