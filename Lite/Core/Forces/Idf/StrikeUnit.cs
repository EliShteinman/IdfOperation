using Lite.Core.Combat;
using Lite.Core.Contracts;
using Lite.Core.Enum;

namespace Lite.Core.Forces.Idf;

public abstract class StrikeUnit : IStrikeUnit
{
    public string Name { get; protected set; }
    public LocationType[] TargetTypes { get; protected set; }
    public int Ammunition => OrdnanceType.Length - _bombsFired;
    public double Fuel { get; protected set; }
    public BombType[] OrdnanceType { get; protected set; }
    private int _bombsFired = 0;

    protected StrikeUnit(string name,
        double fuel,
        LocationType[] targetTypes,
        BombType[] ordnanceType)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name required");
        if (targetTypes == null || targetTypes.Length == 0)
            throw new ArgumentException("TargetTypes required");
        if (fuel < 0) throw new ArgumentException("Fuel must be ≥ 0");

        Name = name;
        TargetTypes = targetTypes;
        Fuel = fuel;
        OrdnanceType = ordnanceType;
    }
    public override string ToString() => Name;

    public virtual StrikeResult Strike()
    {
        if (!IsAvailableForStrike())
        {
            return new StrikeResult(false, null, $"{Name} is not available for strike (No ammo or fuel).");
        }
        return ExecuteStrike();
    }

    protected virtual StrikeResult ExecuteStrike()
    {
        BombType firedBomb = OrdnanceType[_bombsFired];
        _bombsFired++;
        Fuel--;
        var message = $"{Name} fired a {firedBomb}. {Ammunition} rounds left.";
        return new StrikeResult(true, firedBomb, message);
    }

    public virtual bool IsAvailableForStrike()
    {
        return Ammunition > 0 && Fuel > 0;
    }
}