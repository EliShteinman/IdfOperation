using Lite.Core.Contracts;
using Lite.Core.Enum;

namespace Lite.Core.Forces.Idf;

public abstract class StrikeUnit : IStrikeUnit
{
    public string Name { get; protected set; }
    public string[] TargetTypes { get; protected set; }
    public int Ammunition { get; protected set; }
    public double Fuel { get; protected set; }
    
    public BombType[] OrdnanceType { get; protected set; }

    protected StrikeUnit(string name,
        int ammunition,
        double fuel,
        string[] targetTypes,
        BombType[] ordnanceType)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name required");
        if (targetTypes == null || targetTypes.Length == 0)
            throw new ArgumentException("TargetTypes required");
        if (ammunition < 0) throw new ArgumentException("Ammo must be ≥ 0");
        if (fuel < 0) throw new ArgumentException("Fuel must be ≥ 0");

        Name = name;
        TargetTypes = targetTypes;
        Ammunition = ammunition;
        Fuel = fuel;
        OrdnanceType = ordnanceType;
    }
    public override string ToString() => Name;

    public virtual bool Strike()
    {
        if (!IsAvailableForStrike()) return false;
        ExecuteStrike();
        return true;
    }
    protected abstract void ExecuteStrike();
    public abstract bool IsAvailableForStrike();
}