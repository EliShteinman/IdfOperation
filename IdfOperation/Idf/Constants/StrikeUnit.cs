using IdfOperation.Interfaces;

namespace IdfOperation.Idf.Constants;

public abstract class StrikeUnit : IStrikeUnit
{
    public string Name { get; protected set; }
    public int Ammunition { get; protected set; }
    public double Fuel { get; protected set; }
    public string[] TargetTypes { get; protected set; }
    public int StrikeCycleLimit { get; protected set; }


    protected StrikeUnit(string name, int ammunition, double fuel, string[] targetTypes, int strikeLimit)
    {
        Name = name;
        Ammunition = ammunition;
        Fuel = fuel;
        TargetTypes = targetTypes;
        StrikeCycleLimit = strikeLimit;
    }

    public virtual bool Strike()
    {
        if (!IsAvailableForStrike()) return false;

        Ammunition--;
        Fuel--;
        StrikeCycleLimit--;
        return true;
    }

    public virtual bool IsAvailableForStrike()
    {
        return HasAmmunition() && HasFuel() && CanOperate();
    }

    protected virtual bool HasAmmunition() => Ammunition > 0;
    protected virtual bool HasFuel() => Fuel > 0;
    protected virtual bool CanOperate() => StrikeCycleLimit > 0;

}