using IdfOperation.Idf.Constants;

namespace IdfOperation.Idf.Commands.AirForce.Forces;

/// <summary>
/// מחלקה בסיסית המייצגת כטב"ם
/// </summary>
public abstract class Drone : StrikeUnit
{
    /// <summary>
    /// יוצר כטב"ם חדש
    /// </summary>
    /// <param name="name">שם הכטב"ם</param>
    /// <param name="ammunition">כמות תחמושת התחלתית</param>
    /// <param name="fuel">כמות דלק התחלתית</param>
    /// <param name="targetTypes">סוגי מטרות</param>
    /// <param name="strikeLimit">מספר תקיפות מקסימלי במחזור</param>
    protected Drone(string name, int ammunition, double fuel, string[] targetTypes, int strikeLimit)
        : base(name, ammunition, fuel, targetTypes, strikeLimit)
    {
    }
}
