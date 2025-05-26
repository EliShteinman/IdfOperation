namespace IdfOperation.Forces.Idf.CombatUnits;

public abstract class StrikeUnit : CombatUnit
{
    public string Name { get; protected set; }

    public int Ammunition { get; protected set; }                 // כמות תחמושת
    public double Fuel { get; protected set; }                    // כמות דלק
    public string TargetType { get; protected set; }               // סוג המטרה (אנשים, מבנים וכו')
    public int StrikeCycleLimit { get; protected set; }            // כמות תקיפות אפשריות 

    public abstract bool Strike();                               // פעולה תקיפה
}