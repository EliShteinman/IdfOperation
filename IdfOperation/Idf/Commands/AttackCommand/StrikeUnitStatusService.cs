using IdfOperation.Idf.Constants;
using IdfOperation.Interfaces;

namespace IdfOperation.Idf.Commands.AttackCommand;

/// <summary>
/// מחלקה סטטית האחראית על ניהול סטטוס יחידות התקיפה
/// </summary>
public static class StrikeUnitStatusService
{
    /// <summary>
    /// מחזיר את כל יחידות התקיפה בצה"ל
    /// </summary>
    /// <returns>רשימת כל יחידות התקיפה</returns>
    public static List<StrikeUnit> GetAllStrikeUnits()
    {
        return Idf.Instance.StrikeUnits;
    }

    /// <summary>
    /// מחזיר דוח סטטוס מפורט על יחידת תקיפה
    /// </summary>
    /// <param name="unit">יחידת התקיפה</param>
    /// <returns>מחרוזת המכילה את פרטי הסטטוס של היחידה</returns>
    public static string GetUnitStatusReport(StrikeUnit unit)
    {
        return $"יחידה: {unit.Name}\n" +
               $"תחמושת: {unit.Ammunition}\n" +
               $"דלק: {unit.Fuel}\n" +
               $"מחזורי תקיפה נותרו: {unit.StrikeCycleLimit}";
    }

    private static Idf idfInstance = Idf.Instance;
    private static int GetAmmunitionStatus(StrikeUnit unit)
    {
        return unit.Ammunition;
    }

    private static double GetFuelStatus(StrikeUnit unit)
    {
        return unit.Fuel;
    }

    private static int GetStrikeCycleLimit(StrikeUnit unit)
    {
        return unit.StrikeCycleLimit;
    }

    public static Dictionary<string, Dictionary<string, string>> GenerateFullUnitsStatusReportAsDictionary()
    {
        var reportData = new Dictionary<string, Dictionary<string, string>>();
        foreach (var unit in idfInstance.StrikeUnits)
        {
            reportData.Add(unit.Name, new Dictionary<string, string>()
            {
                {"Ammunition", GetAmmunitionStatus(unit).ToString()},
                {"Fuel", GetFuelStatus(unit).ToString()},
                {"Strike Cycle Limit", GetStrikeCycleLimit(unit).ToString()}
            });
        }
        return reportData;
    }
}
