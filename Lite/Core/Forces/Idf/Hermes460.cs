using Lite.Core.Validation;
using Lite.Core.Enum;

namespace Lite.Core.Forces.Idf;

public class Hermes460 : Drone
{
    public Hermes460(string name, int ammunition, double fuel,  string[] targetTypes, BombType[] ordnanceType)
        : base(name,
            ValidAmmuition(ammunition),
            ValidFuel(fuel),
            ValidTargets(targetTypes),
            ValidOrdnanceType(ordnanceType))
    {

    }
    private static int ValidAmmuition(int ammo)
    {
        const int maxAmmo = 3;
        if (ammo > maxAmmo)
            throw new ArgumentException($"Hermes460 cannot hold more than {maxAmmo} rounds");
        return ammo;
    }
    private static double ValidFuel(double fuel)
    {
        return fuel;
    }
    
    private static readonly BombType[] AllowedTypesOrdnance = [BombType.AntiArmor,BombType.AntiPersonnel];
    private static BombType[] ValidOrdnanceType(BombType[] ordnanceType)
    {
        OrdnanceValidation.EnsureExactMatch(ordnanceType, AllowedTypesOrdnance, "Hermes460");
        return ordnanceType;
    }

    private static readonly string[] AllowedTargets = ["Personnel", "Vehicles"];
    private static string[] ValidTargets(string[] targetTypes)
    {
        TargetValidation.EnsureExactMatch(targetTypes, AllowedTargets, "Hermes460");
        return targetTypes;
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