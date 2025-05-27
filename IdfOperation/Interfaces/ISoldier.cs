namespace IdfOperation.Interfaces;

public interface ISoldier : INamedEntity
{
    string Rank { get; }
    string Assignment { get; }
}