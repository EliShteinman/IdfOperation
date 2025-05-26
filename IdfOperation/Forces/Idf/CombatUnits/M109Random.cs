using IdfOperation.Utils;
namespace IdfOperation.Forces.Idf.CombatUnits;

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