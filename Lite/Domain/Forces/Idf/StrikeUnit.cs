using Lite.Domain.Contracts;

namespace Lite.Domain.Forces.Idf;

public abstract class StrikeUnit : IStrikeUnit
{
    public string Name { get; protected set; }
    public string[] TargetTypes { get; protected set; }
    public int Ammunition { get; protected set; }
    public double Fuel { get; protected set; }
    public int StrikeCycleLimit { get; protected set; }

    protected StrikeUnit(string name,
        int ammunition,
        double fuel,
        int strikeLimit,
        string[] targetTypes)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name required");
        if (targetTypes == null || targetTypes.Length == 0)
            throw new ArgumentException("TargetTypes required");
        if (ammunition < 0) throw new ArgumentException("Ammo must be ≥ 0");
        if (fuel < 0) throw new ArgumentException("Fuel must be ≥ 0");
        if (strikeLimit < 0) throw new ArgumentException("StrikeCycleLimit must be ≥ 0");

        Name = name;
        TargetTypes = targetTypes;
        Ammunition = ammunition;
        Fuel = fuel;
        StrikeCycleLimit = strikeLimit;
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