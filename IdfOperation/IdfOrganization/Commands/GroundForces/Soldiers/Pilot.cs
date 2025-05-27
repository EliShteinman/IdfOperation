using IdfOperation.Utils;

namespace IdfOperation.IdfOrganization.Commands.GroundForces.Soldiers;

public class Pilot : IdfSoldier
{
    private const int MinPilotRankIndex = 4; // Capt.
    private const int MaxPilotRankIndexExclusive = 9; // Excludes Lt.Gen.
    public Pilot()
        : base(
            RandomGenerators.NameRandom.GenerateName(),
            Ranks[RandomGenerators.SharedRandom.Next(MinPilotRankIndex, MaxPilotRankIndexExclusive)],
            "Pilot")
    {

    }
}