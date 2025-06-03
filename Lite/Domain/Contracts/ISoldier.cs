using Lite.Domain.Enum;

namespace Lite.Domain.Contracts;

public interface ISoldier : INamedEntity
{
    IdfRanks IdfRank { get; }

    Assignments Assignment { get; }
}
