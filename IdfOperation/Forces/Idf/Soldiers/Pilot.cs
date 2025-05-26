using IdfOperation.NameGenerator;
namespace IdfOperation.Forces.Idf.Soldiers;

public class Pilot : IdfSoldier
{
    private static readonly RandomName NameRandom = new RandomName();
    private static readonly Random SharedRandom = new Random();
    public Pilot() 
        : base()
    {
        
    }
}