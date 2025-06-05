using Lite.Core.Enum;

namespace Lite.Core.Contracts;

public interface ISoldier : INamedEntity
{
    IdfRanks IdfRank { get; }

    Assignments Assignment { get; }
}
