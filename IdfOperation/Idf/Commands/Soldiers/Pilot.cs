using IdfOperation.Idf.Constants;
using IdfOperation.Utils;

namespace IdfOperation.Idf.Commands.Soldiers;

public class Pilot : IdfSoldier
{
    private static readonly Ranks[] PilotRanks =
    [
        Ranks.Capt,
        Ranks.Maj,
        Ranks.LtCol,
        Ranks.Col,
        Ranks.MajGen
    ];

    private static Ranks GetRandomPilotRank()
    {
        return PilotRanks[RandomGenerators.SharedRandom.Next(PilotRanks.Length)];
    }
    public Pilot()
        : base(
            RandomGenerators.NameRandom.GenerateName(),
            GetRandomPilotRank(),
            Assignments.Pilot)
    {

    }
}