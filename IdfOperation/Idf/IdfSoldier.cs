using IdfOperation.Interfaces;
using IdfOperation.Idf.Constants;
namespace IdfOperation.Idf;

public abstract class IdfSoldier : ISoldier
{
    public string Name { get; protected set; }
    public Ranks Rank { get; protected set; }    // public string Assignment { get; protected set; }
    public Assignments Assignment { get; protected set; }
    

    protected IdfSoldier(string name, Ranks rank, Assignments assignment)
    {
        Name = name;
        Rank = rank;
        Assignment = assignment;
    }
}