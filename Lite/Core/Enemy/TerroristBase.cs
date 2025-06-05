using Lite.Core.Combat.Weapons;
using Lite.Core.Contracts;

namespace Lite.Core.Enemy;

public abstract class TerroristBase : ITerrorist
{
    public string Name { get; protected set; }
    public int Rank { get; protected set; }
    public bool Status { get; set; } = true;
    public IReadOnlyList<WeaponBase> Weapons { get; protected set; }
    protected TerroristBase(string name, int rank, IEnumerable<WeaponBase> weapons)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name required");
        if (rank <= 0)
            throw new ArgumentException("TerroristRank must be positive");
        if (rank > 5)
            throw new ArgumentException("TerroristRank must be between 1 and 5.");
        if (weapons == null || !weapons.Any())
            throw new ArgumentException("Terrorist must have at least one weapon");
        Name = name;
        Rank = rank;
        Weapons = weapons.ToList();
    }
    public override string ToString() => Name;
}