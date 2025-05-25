using IdfOperation.Forces;

namespace IdfOperation.Intelligence;

public static class ThreatAnalysis
{
    public static int Analysis(Terrorist terrorist)
    {
        int risk = 0;
        foreach (IWeapon weapon in terrorist.Weapons)
        {
            risk += weapon.Score;
        }
        return risk * terrorist.Rank;
    }
}