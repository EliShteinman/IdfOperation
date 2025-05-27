using IdfOperation.Idf.Constants;

namespace IdfOperation.Interfaces;

public interface ISoldier : INamedEntity
{
    Ranks Rank { get; }
    Assignments Assignment { get; }
}