using IdfOperation.Idf.Commands.Intelligence;
using IdfOperation.Idf.Constants;
using IdfOperation.Interfaces;

namespace IdfOperation.Idf.Commands.AttackCommand;

public static class AttackCommander
{
    public static bool Attack(Message message)
    {
        ITerrorist terrorist = message.Terrorist;
        string zone = message.Zone;
        (bool success, StrikeUnit? selectedUnit) result = FindUnit(zone);
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
    public static (bool,StrikeUnit?) FindUnit(string zone)
    {
        StrikeUnit selectedUnit = null;

        try
        {
            selectedUnit = StrikeAssignmentAnalyzer.GetFirstAvailableUnitForStrike(zone);
            return (true, selectedUnit);
            
        }
        catch (Exception e)
        {
            return (false, null);
        }
    }
}