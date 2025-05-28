using IdfOperation.Idf.Constants;

namespace IdfOperation.Idf.Commands.GroundForces.Forces;

/// <summary>
/// מחלקה בסיסית המייצגת תותח
/// </summary>
public abstract class Artillery : StrikeUnit
{
    /// <summary>
    /// יוצר תותח חדש
    /// </summary>
    /// <param name="name">שם התותח</param>
    /// <param name="ammunition">כמות תחמושת התחלתית</param>
    /// <param name="fuel">כמות דלק התחלתית</param>
    /// <param name="targetTypes">סוגי מטרות</param>
    /// <param name="strikeLimit">מספר תקיפות מקסימלי במחזור</param>
    protected Artillery(string name, int ammunition, double fuel, string[] targetTypes, int strikeLimit)
        : base(name, ammunition, fuel, targetTypes, strikeLimit)
    {
    }
}
