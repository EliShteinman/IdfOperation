using IdfOperation.Idf.Constants;

namespace IdfOperation.Idf.Commands.AirForce.Forces;

/// <summary>
/// מחלקה בסיסית המייצגת מטוס
/// </summary>
public abstract class Plane : StrikeUnit1
{
    /// <summary>
    /// הטייס המפעיל את המטוס
    /// </summary>
    public IdfSoldier Pilot { get; protected set; }

    /// <summary>
    /// יוצר מטוס חדש
    /// </summary>
    /// <param name="name">שם המטוס</param>
    /// <param name="ammunition">כמות תחמושת התחלתית</param>
    /// <param name="fuel">כמות דלק התחלתית</param>
    /// <param name="targetTypes">סוגי מטרות</param>
    /// <param name="strikeLimit">מספר תקיפות מקסימלי במחזור</param>
    /// <param name="pilot">טייס המטוס</param>
    protected Plane(string name, int ammunition, double fuel, string[] targetTypes, int strikeLimit, IdfSoldier pilot)
        : base(name, ammunition, fuel, targetTypes, strikeLimit)
    {
        this.Pilot = pilot;
    }

}
