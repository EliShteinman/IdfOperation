using IdfOperation.Idf.Constants;
namespace IdfOperation.Idf.Commands.AttackCommand;

public static class StrikeUnitStatusService
{
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