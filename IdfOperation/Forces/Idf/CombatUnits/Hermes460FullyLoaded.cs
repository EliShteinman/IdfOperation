using IdfOperation.Utils;
namespace IdfOperation.Forces.Idf.CombatUnits;

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