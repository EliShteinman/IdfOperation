using Lite.Core.Validation;
using Lite.Core.Enum;

namespace Lite.Core.Forces.Idf;

public class Hermes460 : Drone
{
    private static readonly BombType[] AllowedTypesOrdnance = [BombType.AntiArmor, BombType.AntiPersonnel];
    private static readonly LocationType[] AllowedTargets = [LocationType.Personnel, LocationType.Vehicles];
    private const int MaxOrdnanceCapacity = 3;


    public Hermes460(string name, double fuel, LocationType[] targetTypes, BombType[] ordnanceLoad)
        : base(name,
            ValidFuel(fuel),
            ValidTargets(targetTypes),
            ValidateLoadout(ordnanceLoad, name))
    {

    }
    private static double ValidFuel(double fuel)
    {
        return fuel;
    }
    private static LocationType[] ValidTargets(LocationType[] targetTypes)
    {
        TargetValidation.EnsureExactMatch(targetTypes, AllowedTargets, "Hermes460");
        return targetTypes;
    }
    private static BombType[] ValidateLoadout(BombType[] ordnanceLoad, string unitName)
    {
        if (ordnanceLoad.Length > MaxOrdnanceCapacity)
        {
            throw new ArgumentException($"{unitName} (Hermes460) cannot carry more than {MaxOrdnanceCapacity} bombs. Provided loadout size: {ordnanceLoad.Length}");
        }
        OrdnanceValidation.EnsureAllOrdnanceTypesArePermitted(ordnanceLoad, AllowedTypesOrdnance, unitName);
        return ordnanceLoad;
    }
}