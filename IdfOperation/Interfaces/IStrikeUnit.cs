namespace IdfOperation.Interfaces;

/// <summary>
/// ממשק המייצג יחידת תקיפה בצה"ל
/// </summary>
public interface IStrikeUnit
{
    /// <summary>
    /// כמות התחמושת הזמינה
    /// </summary>
    int Ammunition { get; }

    /// <summary>
    /// כמות הדלק הזמין
    /// </summary>
    double Fuel { get; }

    /// <summary>
    /// סוגי המטרות שיחידת התקיפה יכולה לתקוף
    /// </summary>
    string[] TargetTypes { get; }

    /// <summary>
    /// מספר מחזורי התקיפה המקסימלי
    /// </summary>
    int StrikeCycleLimit { get; }

    /// <summary>
    /// מבצע תקיפה
    /// </summary>
    /// <returns>אמת אם התקיפה הצליחה, אחרת שקר</returns>
    bool Strike();

    /// <summary>
    /// בודק האם יחידת התקיפה זמינה לביצוע תקיפה
    /// </summary>
    /// <returns>אמת אם היחידה זמינה, אחרת שקר</returns>
    bool IsAvailableForStrike();
}
