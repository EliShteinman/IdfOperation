using IdfOperation.Utils;
using IdfOperation.Idf.Constants;

namespace IdfOperation.Idf.Commands.Soldiers;

public class SoldierRandomized : IdfSoldier
{
    private static Ranks[] allRanks = (Ranks[])Enum.GetValues(typeof(Ranks));
    private static Assignments[] allAssignments = (Assignments[])Enum.GetValues(typeof(Assignments));
    public SoldierRandomized()
        : base(
            RandomGenerators.NameRandom.GenerateName(),
            allRanks[RandomGenerators.SharedRandom.Next(allRanks.Length)],
            allAssignments[RandomGenerators.SharedRandom.Next(allAssignments.Length)])
    {

    }
}