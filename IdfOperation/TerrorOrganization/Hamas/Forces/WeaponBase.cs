namespace IdfOperation.TerrorOrganization.Hamas.Forces;

/// <summary>
/// מחלקה בסיסית המייצגת נשק
/// </summary>
public abstract class WeaponBase
{
    /// <summary>
    /// סוג הנשק
    /// </summary>
    public string Type { get; protected set; }

    /// <summary>
    /// ציון הנשק (משקף את רמת הסכנה שלו)
    /// </summary>
    public int Score { get; protected set; }

    /// <summary>
    /// יוצר נשק חדש
    /// </summary>
    /// <param name="type">סוג הנשק</param>
    protected WeaponBase(string type)
    {
        Type = type;
        Score = CalculateScore(type);
    }

    /// <summary>
    /// מחשב את ציון הנשק בהתאם לסוגו
    /// </summary>
    /// <param name="type">סוג הנשק</param>
    /// <returns>ציון הנשק (1-3)</returns>
    protected abstract int CalculateScore(string type);
}
