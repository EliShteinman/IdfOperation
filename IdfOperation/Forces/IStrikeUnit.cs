namespace IdfOperation.Forces;

public interface IStrikeUnit:ICombatUnit
{
    int Ammunition { get; set; }                 // כמות תחמושת
    double Fuel { get; set; }                    // כמות דלק
    string TargetType { get; set; }               // סוג המטרה (אנשים, מבנים וכו')
    int StrikeCycleLimit { get; set; }            // כמות תקיפות אפשריות 
    
    bool Strike();                               // פעולה תקיפה
}