using Lite.Domain.Combat.Weapons;
namespace Lite.Domain.Contracts;

public interface ITerrorist : INamedEntity
{
    int Rank { get; }
    bool Status { get; set; }
    IReadOnlyList<WeaponBase> Weapons { get; }
}
