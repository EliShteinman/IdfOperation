namespace IdfOperation.Forces.Idf;

public abstract class IdfSoldier : ISoldier
{
    public string Name { get; set; }
    public string Rank { get; set; }
    public string Assignment { get; set; }

    protected IdfSoldier(string name, string rank, string assignment)
    {
        Name = name;
        Rank = rank;
        Assignment = assignment;
    }
}