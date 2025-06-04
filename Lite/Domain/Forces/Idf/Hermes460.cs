using Lite.Domain.Validation;
namespace Lite.Domain.Forces.Idf;

public class Hermes460 : Drone
{
    public Hermes460(string name, int ammunition, double fuel, int strikeLimit, string[] targetTypes)
        : base(name,
            ValidAmmuition(ammunition),
            ValidFuel(fuel),
            ValidStrikeLimit(strikeLimit),
            ValidTargets(targetTypes))
    {
        
    }
    private static int ValidAmmuition(int ammo)
    {
        const int maxAmmo = 40;
        if (ammo > maxAmmo)
            throw new ArgumentException($"Hermes460 cannot hold more than {maxAmmo} rounds");
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
    private static readonly string[] AllowedTargets = ["Buildings"];
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