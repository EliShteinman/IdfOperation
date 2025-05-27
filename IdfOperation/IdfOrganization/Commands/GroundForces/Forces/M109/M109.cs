
namespace IdfOperation.IdfOrganization.Commands.GroundForces.Forces.M109;

public abstract class M109 : Artillery
{
    public M109(string name, int ammunition, double fuel, int strikeLimit)
         : base
            (
            ValidName(name),
            ValidAmmunition(ammunition),
            ValidFuel(fuel),
            ["OpenArea"],
            ValidStrikeLimit(strikeLimit)
            )
    {

    }
    private static string ValidName(string name)
    {
        return name;
    }
    private static int ValidAmmunition(int ammunition)
    {
        if (ammunition < 0)
        {
            throw new ArgumentException("Must give a positive value.");
        }
        else
        if (ammunition > 40)
        {
            throw new ArgumentException("Quantity limited to forty");
        }
        return ammunition;

    }
    private static double ValidFuel(double fuel)
    {
        if (fuel < 0)
        {
            throw new ArgumentException("Must give a positive value.");
        }
        else
        if (fuel > 40)
        {
            throw new ArgumentException("Quantity limited to forty");
        }
        return fuel;

    }
    private static int ValidStrikeLimit(int strikeLimit)
    {
        if (strikeLimit < 0)
        {
            throw new ArgumentException("Must give a positive value.");
        }
        else
        if (strikeLimit > 40)
        {
            throw new ArgumentException("Quantity limited to forty");
        }
        return strikeLimit;

    }
}