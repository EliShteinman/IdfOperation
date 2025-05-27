using IdfOperation.Interfaces;

namespace IdfOperation.IdfOrganization.Commands.CombatUnits;

public abstract class StrikeUnit : CombatUnit
{
    public int Ammunition { get; protected set; }                 // כמות תחמושת
    public double Fuel { get; protected set; }                    // כמות דלק
    public string[] TargetTypes { get; protected set; }               // סוג המטרה (אנשים, מבנים וכו')
    public int StrikeCycleLimit { get; protected set; }            // כמות תקיפות אפשריות 


    protected StrikeUnit(string name, int ammunition, double fuel, string[] targetTypes, int strikeLimit)

    {
        base.Name = name;
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