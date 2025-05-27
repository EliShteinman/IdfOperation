namespace IdfOperation.Idf.Commands.AirForce.Forces.Hermes460;

public abstract class Hermes460 : Drone
{
    public Hermes460(string name, int ammunition, double fuel, int strikeLimit)
         : base(
             ValidName(name),
             ValidAmmunition(ammunition),
             ValidFuel(fuel),
             ["People", "Vehicles"],
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
        if (ammunition > 3)
        {
            throw new ArgumentException("Quantity limited to three");
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
        if (fuel > 3)
        {
            throw new ArgumentException("Quantity limited to three");
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
        if (strikeLimit > 3)
        {
            throw new ArgumentException("Quantity limited to three");
        }
        return strikeLimit;

    }

}