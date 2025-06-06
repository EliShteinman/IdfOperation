using IdfOperation.Idf.Constants;

namespace IdfOperation.Idf.Commands.AttackCommand;

/// <summary>
/// מחלקה סטטית האחראית על ניתוח והקצאת יחידות תקיפה למשימות
/// </summary>
public static class StrikeAssignmentAnalyzer
{
    /// <summary>
    /// מחזיר את כל יחידות התקיפה המסוגלות לתקוף באזור מסוים
    /// </summary>
    /// <param name="zone">אזור המטרה</param>
    /// <returns>רשימת יחידות התקיפה המתאימות</returns>
    public static List<StrikeUnit> GetUnitsCapableOfTargeting(string zone)
    {
        var idfInstance = Idf.Instance;
        List<StrikeUnit> temp = new List<StrikeUnit>();
        foreach (var strikeUnit in idfInstance.StrikeUnits)
        {
            if (strikeUnit.TargetTypes.Contains(zone))
            {
                temp.Add(strikeUnit);
            }
        }

        return temp;
    }

    /// <summary>
    /// מסנן את יחידות התקיפה הזמינות מתוך רשימה נתונה
    /// </summary>
    /// <param name="unitsToFilter">רשימת יחידות התקיפה לסינון</param>
    /// <returns>רשימת יחידות התקיפה הזמינות</returns>
    public static List<StrikeUnit> FilterAvailableUnits(List<StrikeUnit> unitsToFilter)
    {
        var availableUnits = new List<StrikeUnit>();
        foreach (var strikeUnit in unitsToFilter)
        {
            if (strikeUnit.IsAvailableForStrike()) // בודק האם היחידה זמינה לתקיפה
            {
                availableUnits.Add(strikeUnit);
            }
        }

        return availableUnits;
    }

    /// <summary>
    /// מחזיר את יחידת התקיפה הזמינה הראשונה המתאימה לאזור המטרה
    /// </summary>
    /// <param name="targetZone">אזור המטרה</param>
    /// <returns>יחידת התקיפה שנמצאה</returns>
    /// <exception cref="Exception">נזרק כאשר לא נמצאה יחידת תקיפה מתאימה</exception>
    public static StrikeUnit GetFirstAvailableUnitForStrike(string targetZone)
    {
        List<StrikeUnit> capableUnits = GetUnitsCapableOfTargeting(targetZone);
        List<StrikeUnit> availableUnits = FilterAvailableUnits(capableUnits);
        if (availableUnits.Count > 0)
        {
            return availableUnits[0];
        }
        throw new Exception("No available units for strike");
    }
}
