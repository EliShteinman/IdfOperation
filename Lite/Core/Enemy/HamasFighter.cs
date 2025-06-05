using Lite.Core.Combat.Weapons;

namespace Lite.Core.Enemy;

public sealed class HamasFighter : TerroristBase
{
    public HamasFighter(string name, int rank, IEnumerable<WeaponBase> weapons)
        : base(name, rank, weapons)
    {

    }
}