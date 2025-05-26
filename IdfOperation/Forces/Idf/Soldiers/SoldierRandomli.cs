using IdfOperation.NameGenerator;
namespace IdfOperation.Forces.Idf.Soldiers;

public class SoldierRandomli : IdfSoldier
{
    private static readonly RandomName NameRandom = new RandomName();
    private static readonly Random SharedRandom = new Random();


    public SoldierRandomli()
        : base(
            NameRandom.GenerateName(),
            Ranks[SharedRandom.Next(Ranks.Length)],
            Assignments[SharedRandom.Next(Assignments.Length)])
    {
        
    }
}