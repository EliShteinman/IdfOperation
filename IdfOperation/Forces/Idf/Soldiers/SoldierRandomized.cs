using IdfOperation.Utils;
namespace IdfOperation.Forces.Idf.Soldiers;

public class SoldierRandomized : IdfSoldier
{
    public SoldierRandomized()
        : base(
            RandomGenerators.NameRandom.GenerateName(),
            Ranks[RandomGenerators.SharedRandom.Next(Ranks.Length)],
            Assignments[RandomGenerators.SharedRandom.Next(Assignments.Length)])
    {

    }
}