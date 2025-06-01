using System.Diagnostics.CodeAnalysis;
using Lite.Domain.Contracts;

namespace Lite.Application.Services;

public static class ThreatAnalysis
{
    public static int CalculateRisk(ITerrorist t)
    {
        ArgumentNullException.ThrowIfNull(t);
        if (t.Weapons == null)
            throw new ArgumentException("Terrorist has null weapon list");

        if (!t.Weapons.Any())
            throw new ArgumentException("Terrorist has no weapons");
        var sumWeapon = 0;
        foreach (var weapon in t.Weapons)
        {
            sumWeapon += weapon.Score;
        }
        return sumWeapon * t.Rank;
    }
}