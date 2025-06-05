namespace Lite.Core.Combat.Weapons;

public abstract class WeaponBase
{
    public abstract string Name { get; }

    public abstract int Score { get; }
    public override string ToString() => Name;
}
