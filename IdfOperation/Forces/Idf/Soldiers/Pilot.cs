using IdfOperation.Utils;
namespace IdfOperation.Forces.Idf.Soldiers;

public class Pilot : IdfSoldier
{
    public Pilot()
        : base(
            RandomGenerators.NameRandom.GenerateName(),
            Ranks[RandomGenerators.SharedRandom.Next(4, 9)],
            "Pilot")
    {
        
    }
}