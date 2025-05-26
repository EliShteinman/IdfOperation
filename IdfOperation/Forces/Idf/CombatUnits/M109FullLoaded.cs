using IdfOperation.Utils;
namespace IdfOperation.Forces.Idf.CombatUnits;

public class M109FullLoaded : M109
{
    public M109FullLoaded()
        : base(
            RandomGenerators.Serial.GetNext("M109"),
            40,
            40,
            40
        )
    {

    }
}