using IdfOperation.Utils;
namespace IdfOperation.Forces.Idf.Soldiers;

public class SoldierRandomli : IdfSoldier
{



    public SoldierRandomli()
        : base(
            RandomGenerators.NameRandom.GenerateName(),
            Ranks[RandomGenerators.SharedRandom.Next(Ranks.Length)],
            Assignments[RandomGenerators.SharedRandom.Next(Assignments.Length)])
    {
        
    }
}