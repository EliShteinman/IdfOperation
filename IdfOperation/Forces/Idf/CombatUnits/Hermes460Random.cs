using IdfOperation.Utils;
namespace IdfOperation.Forces.Idf.CombatUnits;

public class Hermes460Random : Hermes460
{
    public Hermes460Random()
        : base(
            RandomGenerators.Serial.GetNext("Hermes460"),
            RandomGenerators.SharedRandom.Next(4),
            RandomGenerators.SharedRandom.Next(4),
            RandomGenerators.SharedRandom.Next(4)
        )
    {

    }
}