using Lite.Core.Contracts;
using Lite.Core.Validation;
using Lite.Core.Enum;

namespace Lite.Core.Forces.Idf;

public class F16 : Plane
{
    private static readonly LocationType[] AllowedTargets = [LocationType.Structures];
    private static readonly BombType[] AllowedTypesOrdnance = [BombType.BombGp500Kg, BombType.BombGp1000Kg];
    private const int MaxOrdnanceCapacity = 8;
    
    public F16(string name, double fuel, LocationType[] targetTypes, ISoldier pilot, BombType[] ordnanceLoad)
        : base(name,
            ValidFuel(fuel),
            ValidTargets(targetTypes),
            ValidateLoadout(ordnanceLoad, name),
            pilot)
    {

    }
    private static double ValidFuel(double fuel)
    {
        return fuel;
    }
    private static LocationType[] ValidTargets(LocationType[] targetTypes)
    {
        TargetValidation.EnsureExactMatch(targetTypes, AllowedTargets, "F16");
        return targetTypes;
    }
    private static BombType[] ValidateLoadout(BombType[] ordnanceLoad, string unitName)
    {
        if (ordnanceLoad.Length > MaxOrdnanceCapacity)
        {
            throw new ArgumentException($"{unitName} (F16) cannot carry more than {MaxOrdnanceCapacity} bombs. Provided loadout size: {ordnanceLoad.Length}");
        }
        OrdnanceValidation.EnsureAllOrdnanceTypesArePermitted(ordnanceLoad, AllowedTypesOrdnance, unitName);
        return ordnanceLoad;
    }
}