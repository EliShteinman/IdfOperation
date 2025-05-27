using IdfOperation.Idf.Commands.AirForce.Forces.F16;
using IdfOperation.Idf.Commands.AirForce.Forces.Hermes460;
using IdfOperation.Idf.Commands.GroundForces.Forces.M109;
using IdfOperation.Idf.Commands.Soldiers;
using IdfOperation.TerrorOrganization.Hamas;
using IdfOperation.TerrorOrganization.Hamas.Forces;
using IdfOperation.Utils;

namespace IdfOperation;
class Program
{
    public static void Main()
    {
        var hamas = Hamas.CreateInstance("hamas", new TerroristRandomizer(), DateTime.Now.AddYears(-15));
        var idf = Idf.Idf.CreateInstance("idf", new ChiefOfStaff(), DateTime.Now.AddYears(-78));
        for (int i = 0; i < RandomGenerators.SharedRandom.Next(5, 10); i++)
        {
            hamas.Terrorists.Add(new TerroristRandomizer());
        }
        idf.StrikeUnits.Add(new F16FullyLoaded());
        idf.StrikeUnits.Add(new Hermes460FullyLoaded());
        idf.StrikeUnits.Add(new M109FullyLoaded());
    }
}