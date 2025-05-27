using IdfOperation.Forces.Idf.CombatUnits;
using IdfOperation.Forces.Idf.Soldiers;
using IdfOperation.Forces.Terror;
using IdfOperation.Organization;
using IdfOperation.Utils;

namespace IdfOperation;
class Program
{
    public static void Main()
    {
        var hamas = new TerrorOrg("hamas", new TerroristRandomizer(), DateTime.Now.AddYears(-15));
        var idf = new Idf("idf", new ChiefOfStaff(), DateTime.Now.AddYears(-78));
        for (int i = 0; i < RandomGenerators.SharedRandom.Next(5, 10); i++)
        {
            hamas.Terrorists.Add(new TerroristRandomizer());
        }
        idf.StrikeUnits.Add(new F16FullyLoaded());
        idf.StrikeUnits.Add(new Hermes460FullyLoaded());
        idf.StrikeUnits.Add(new M109FullyLoaded());
    }
}