using IdfOperation.Idf.Constants;

namespace IdfOperation.Idf.Commands.AttackCommand;

public static class StrikeAssignmentAnalyzer
{
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