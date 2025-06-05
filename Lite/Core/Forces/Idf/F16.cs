using Lite.Core.Contracts;
using Lite.Core.Validation;
using Lite.Core.Enum;

namespace Lite.Core.Forces.Idf;

public class F16 : Plane
{
    public F16(string name, int ammunition, double fuel, string[] targetTypes, ISoldier pilot, BombType ordnanceType)
        : base(name,
            ValidAmmuition(ammunition),
            ValidFuel(fuel),
            ValidTargets(targetTypes),
            ValidOrdnanceType(ordnanceType),
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

    private static readonly string[] AllowedTargets = ["Structures"];
    private static string[] ValidTargets(string[] targetTypes)
    {
        TargetValidation.EnsureExactMatch(targetTypes, AllowedTargets, "F16");
        return targetTypes;
    }

    private static BombType ValidOrdnanceType(BombType ordnanceType)
    {
        return ordnanceType;
    }

    public override bool IsAvailableForStrike()
    {
        return Ammunition > 0 && Fuel > 0;
    }

    protected override void ExecuteStrike()
    {
        Ammunition--;
        Fuel--;
    }
}