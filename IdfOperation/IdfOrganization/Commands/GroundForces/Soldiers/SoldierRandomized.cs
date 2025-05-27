using IdfOperation.Utils;

namespace IdfOperation.IdfOrganization.Commands.GroundForces.Soldiers;

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