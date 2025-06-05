using Lite.Core.Combat.Weapons;

namespace Lite.Core.Contracts;

public interface ITerrorist : INamedEntity
{
    int Rank { get; }
    bool Status { get; set; }
    IReadOnlyList<WeaponBase> Weapons { get; }
}
