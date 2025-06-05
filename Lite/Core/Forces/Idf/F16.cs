using Lite.Core.Contracts;
using Lite.Core.Validation;
using Lite.Core.Enum;

namespace Lite.Core.Forces.Idf;

public class F16 : Plane
{
    public F16(string name, int ammunition, double fuel, KnownLocationType[] targetTypes, ISoldier pilot, BombType[] ordnanceType)
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

    private static readonly KnownLocationType[] AllowedTargets = [KnownLocationType.Structures];
    private static KnownLocationType[] ValidTargets(KnownLocationType[] targetTypes)
    {
        TargetValidation.EnsureExactMatch(targetTypes, AllowedTargets, "F16");
        return targetTypes;
    }

    private static readonly BombType[] AllowedTypesOrdnance = [BombType.BombGp500Kg, BombType.BombGp1000Kg];
    private static BombType[] ValidOrdnanceType(BombType[] ordnanceType)
    {
        OrdnanceValidation.EnsureExactMatch(ordnanceType, AllowedTypesOrdnance, "F16");
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