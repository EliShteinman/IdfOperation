using IdfOperation.Idf.Commands.Intelligence;
using IdfOperation.Idf.Constants;
using IdfOperation.Interfaces;
using IdfOperation.Lite.Domain.Contracts;

namespace IdfOperation.Idf.Commands.AttackCommand;

/// <summary>
/// מחלקה סטטית האחראית על ניהול התקיפות בצה"ל
/// </summary>
public static class AttackCommander
{
    /// <summary>
    /// מבצע תקיפה על טרוריסט בהתבסס על הודעת מודיעין
    /// </summary>
    /// <param name="message">הודעת המודיעין המכילה מידע על הטרוריסט והאזור</param>
    /// <returns>אמת אם התקיפה הצליחה, אחרת שקר</returns>
    public static bool Attack(Message message)
    {
        ITerrorist terrorist = message.Terrorist;
        string zone = message.Zone;
        (bool success, StrikeUnit1? selectedUnit) result = FindUnit(zone);
        if (!result.success)
        {
            return false;
        }

        bool attack = result.selectedUnit.Strike();
        if (attack)
        {
            terrorist.Status = false;
        }

        return attack;
    }

    /// <summary>
    /// מוצא יחידת תקיפה מתאימה לאזור המטרה
    /// </summary>
    /// <param name="zone">אזור המטרה</param>
    /// <returns>טופל המכיל אמת אם נמצאה יחידה מתאימה ויחידת התקיפה שנמצאה</returns>
    public static (bool, StrikeUnit1?) FindUnit(string zone)
    {
        StrikeUnit1 selectedUnit1 = null;

        try
        {
            selectedUnit1 = StrikeAssignmentAnalyzer.GetFirstAvailableUnitForStrike(zone);
            return (true, selectedUnit1);
        }
        catch (Exception e)
        {
            return (false, null);
        }
    }
}
