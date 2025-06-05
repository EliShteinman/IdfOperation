using Lite.Core.Contracts;
using Lite.Core.Validation;

namespace Lite.Core.Forces.Idf;

public class F16 : Plane
{
    public F16(string name, int ammunition, double fuel, int strikeLimit, string[] targetTypes, ISoldier pilot)
        : base(name,
            ValidAmmuition(ammunition),
            ValidFuel(fuel),
            ValidStrikeLimit(strikeLimit),
            ValidTargets(targetTypes),
            pilot)
    {

    }
    private static int ValidAmmuition(int ammo)
    {
        const int maxAmmo = 8;
        if (ammo > maxAmmo)
            throw new ArgumentException($"F16 cannot hold more than {maxAmmo} rounds");
        return ammo;
    }
    private static double ValidFuel(double fuel)
    {
        return fuel;
    }
    private static int ValidStrikeLimit(int strikeLimit)
    {
        return strikeLimit;
    }
    private static readonly string[] AllowedTargets = ["Structures"];
    private static string[] ValidTargets(string[] targetTypes)
    {
        TargetValidation.EnsureExactMatch(targetTypes, AllowedTargets, "F16");
        return targetTypes;
    }

    public override bool IsAvailableForStrike()
    {
        return Ammunition > 0 && Fuel > 0 && StrikeCycleLimit > 0;
    }

    protected override void ExecuteStrike()
    {
        Ammunition--;
        Fuel--;
        StrikeCycleLimit--;
    }
}