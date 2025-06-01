using Lite.Domain.Enum;

namespace Lite.Domain.Contracts;

public interface ISoldier : INamedEntity
{
    Ranks Rank { get; }

    Assignments Assignment { get; }
}
