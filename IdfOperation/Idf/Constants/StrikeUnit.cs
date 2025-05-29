using IdfOperation.Interfaces;

namespace IdfOperation.Idf.Constants;

/// <summary>
/// מחלקה בסיסית המייצגת יחידת תקיפה בצה"ל
/// </summary>
public abstract class StrikeUnit : IStrikeUnit
{
    /// <summary>
    /// שם היחידה
    /// </summary>
    public string Name { get; protected set; }

    /// <summary>
    /// כמות התחמושת הנותרת
    /// </summary>
    public int Ammunition { get; protected set; }

    /// <summary>
    /// כמות הדלק הנותרת
    /// </summary>
    public double Fuel { get; protected set; }

    /// <summary>
    /// סוגי המטרות שהיחידה יכולה לתקוף
    /// </summary>
    public string[] TargetTypes { get; protected set; }

    /// <summary>
    /// מספר התקיפות המקסימלי במחזור פעולה
    /// </summary>
    public int StrikeCycleLimit { get; protected set; }

    /// <summary>
    /// יוצר מופע חדש של יחידת תקיפה
    /// </summary>
    /// <param name="name">שם היחידה</param>
    /// <param name="ammunition">כמות תחמושת התחלתית</param>
    /// <param name="fuel">כמות דלק התחלתית</param>
    /// <param name="targetTypes">סוגי מטרות</param>
    /// <param name="strikeLimit">מספר תקיפות מקסימלי במחזור</param>
    protected StrikeUnit(string name, int ammunition, double fuel, string[] targetTypes, int strikeLimit)
    {
        Name = name;
        Ammunition = ammunition;
        Fuel = fuel;
        TargetTypes = targetTypes;
        StrikeCycleLimit = strikeLimit;
    }

    /// <summary>
    /// מבצע תקיפה
    /// </summary>
    /// <returns>אמת אם התקיפה הצליחה, שקר אחרת</returns>
    public virtual bool Strike()
    {
        if (!IsAvailableForStrike()) return false;

        Ammunition--;
        Fuel--;
        StrikeCycleLimit--;
        return true;
    }

    /// <summary>
    /// בודק האם היחידה זמינה לתקיפה
    /// </summary>
    /// <returns>אמת אם היחידה זמינה, שקר אחרת</returns>
    public virtual bool IsAvailableForStrike()
    {
        return HasAmmunition() && HasFuel() && CanOperate();
    }

    /// <summary>
    /// בודק האם יש תחמושת
    /// </summary>
    protected virtual bool HasAmmunition() => Ammunition > 0;

    /// <summary>
    /// בודק האם יש דלק
    /// </summary>
    protected virtual bool HasFuel() => Fuel > 0;

    /// <summary>
    /// בודק האם היחידה יכולה לפעול
    /// </summary>
    protected virtual bool CanOperate() => StrikeCycleLimit > 0;
}
