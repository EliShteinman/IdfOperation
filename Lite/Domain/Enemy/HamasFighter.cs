using Lite.Domain.Combat.Weapons;

namespace Lite.Domain.Enemy;

public sealed class HamasFighter : TerroristBase
{
    public HamasFighter(string name, int rank, IEnumerable<WeaponBase> weapons)
        : base(name, rank, weapons)
    {

    }
}