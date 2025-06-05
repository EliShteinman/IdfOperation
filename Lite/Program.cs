using Lite.Application.Services;
using Lite.Core.Combat.Weapons;
using Lite.Core.Enemy;

namespace Lite;

class Program
{
    static void Main(string[] args)
    {
        var fighter = new HamasFighter(
            "Ali",
            rank: 2,
            weapons: new WeaponBase[] { new Gun(), new Knife() });

        int risk = ThreatAnalysis.CalculateRisk(fighter);
        Console.WriteLine($"Risk level for {fighter.Name}: {risk}");
    }
}