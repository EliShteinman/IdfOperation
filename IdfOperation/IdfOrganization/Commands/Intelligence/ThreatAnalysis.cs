using IdfOperation.TerrorOrganization.Terror;

namespace IdfOperation.IdfOrganization.Commands.Intelligence;

public static class ThreatAnalysis
{
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