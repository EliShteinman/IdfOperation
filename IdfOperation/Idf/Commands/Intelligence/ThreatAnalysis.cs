using IdfOperation.TerrorOrganization.Hamas.Forces;

namespace IdfOperation.Idf.Commands.Intelligence;

/// <summary>
/// מחלקה האחראית על ניתוח רמת האיום של טרוריסט
/// </summary>
public static class ThreatAnalysis
{
    /// <summary>
    /// מנתח את רמת האיום של טרוריסט
    /// </summary>
    /// <param name="terrorist">הטרוריסט לניתוח</param>
    /// <returns>ציון רמת האיום (מכפלה של ציון הנשקים בדרגת הטרוריסט)</returns>
    public static int Analysis(Terrorist terrorist)
    {
        int risk = 0;
        foreach (WeaponBase weapon in terrorist.Weapons)
        {
            risk += weapon.Score;
        }
        return risk * terrorist.Rank;
    }
}
