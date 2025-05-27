using IdfOperation.Idf.Constants;
namespace IdfOperation.Idf.Commands.AirForce.Forces.F16;

public abstract class F16 : Plane
{
    public F16(string name, int ammunition, double fuel, int strikeLimit, IdfSoldier pilot)

        : base(ValidName(name),
                  ValidAmmunition(ammunition),
                  ValidFuel(fuel),
                  ["Buildings"],
                  ValidStrikeLimit(strikeLimit),
                  ValidPilot(pilot)
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
        if (ammunition > 8)
        {
            throw new ArgumentException("Quantity limited to eight");
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
        if (fuel > 8)
        {
            throw new ArgumentException("Quantity limited to eight");
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
        if (strikeLimit > 8)
        {
            throw new ArgumentException("Quantity limited to eight");
        }
        return strikeLimit;

    }
    private static IdfSoldier ValidPilot(IdfSoldier pilot)
    {
        if (pilot.Assignment != Assignments.Pilot)
        {
            throw new ArgumentException("The soldier must be a pilot type.");
        }
        return pilot;
    }
}