using Lite.Core.Validation;
using Lite.Core.Enum;
namespace Lite.Core.Forces.Idf;

public class M109 : Artillery
{
    private static readonly LocationType[] AllowedTargets = [LocationType.OpenTerrain];
    private static readonly BombType[] AllowedTypesOrdnance = [BombType.HighExplosiveShell];
    private const int MaxOrdnanceCapacity = 40;


    public M109(string name, double fuel, LocationType[] targetTypes, BombType[] ordnanceLoad)
        : base(
            name,
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
        TargetValidation.EnsureExactMatch(targetTypes, AllowedTargets, "M109");
        return targetTypes;
    }
    private static BombType[] ValidateLoadout(BombType[] ordnanceLoad, string unitName)
    {
        if (ordnanceLoad.Length > MaxOrdnanceCapacity)
        {
            throw new ArgumentException($"{unitName} (M109) cannot carry more than {MaxOrdnanceCapacity} bombs. Provided loadout size: {ordnanceLoad.Length}");
        }
        OrdnanceValidation.EnsureAllOrdnanceTypesArePermitted(ordnanceLoad, AllowedTypesOrdnance, unitName);
        return ordnanceLoad;
    }
}