using Lite.Core.Validation;
using Lite.Core.Enum;
namespace Lite.Core.Forces.Idf;

public class M109 : Artillery
{
    private static readonly KnownLocationType[] AllowedTargets = [KnownLocationType.OpenTerrain];
    private static readonly BombType[] AllowedTypesOrdnance = [BombType.HighExplosiveShell];

    public M109(string name, int ammunition, double fuel,  KnownLocationType[] targetTypes, BombType[] ordnanceType)
        : base(
            name,
            ValidAmmunition(ammunition),
            ValidFuel(fuel),
            ValidTargets(targetTypes),
            ValidOrdnanceType(ordnanceType))
    {

    }
    private static int ValidAmmunition(int ammo)
    {
        const int maxAmmo = 40;
        if (ammo > maxAmmo)
            throw new ArgumentException($"M109 cannot hold more than {maxAmmo} rounds");
        return ammo;
    }
    private static double ValidFuel(double fuel)
    {
        return fuel;
    }
    private static KnownLocationType[] ValidTargets(KnownLocationType[] targetTypes)
    {
        TargetValidation.EnsureExactMatch(targetTypes, AllowedTargets, "M109");
        return targetTypes;
    }
    private static BombType[] ValidOrdnanceType(BombType[] ordnanceType)
    {
        OrdnanceValidation.EnsureExactMatch(ordnanceType, AllowedTypesOrdnance, "M109");
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