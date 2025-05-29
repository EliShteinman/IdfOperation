using IdfOperation.Idf.Constants;
namespace IdfOperation.Idf.Commands.AirForce.Forces.F16;

/// <summary>
/// מחלקה המייצגת מטוס קרב מסוג F16
/// </summary>
public abstract class F16 : Plane
{
    /// <summary>
    /// יוצר מופע חדש של מטוס F16
    /// </summary>
    /// <param name="name">שם המטוס</param>
    /// <param name="ammunition">כמות תחמושת התחלתית (0-8)</param>
    /// <param name="fuel">כמות דלק התחלתית (0-8)</param>
    /// <param name="strikeLimit">מספר תקיפות מקסימלי במחזור (0-8)</param>
    /// <param name="pilot">טייס המטוס</param>
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

    /// <summary>
    /// בודק את תקינות שם המטוס
    /// </summary>
    private static string ValidName(string name)
    {
        return name;
    }

    /// <summary>
    /// בודק את תקינות כמות התחמושת
    /// </summary>
    /// <exception cref="ArgumentException">נזרק כאשר כמות התחמושת אינה בטווח המותר (0-8)</exception>
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

    /// <summary>
    /// בודק את תקינות כמות הדלק
    /// </summary>
    /// <exception cref="ArgumentException">נזרק כאשר כמות הדלק אינה בטווח המותר (0-8)</exception>
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

    /// <summary>
    /// בודק את תקינות מספר התקיפות המקסימלי
    /// </summary>
    /// <exception cref="ArgumentException">נזרק כאשר מספר התקיפות אינו בטווח המותר (0-8)</exception>
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

    /// <summary>
    /// בודק את תקינות הטייס
    /// </summary>
    /// <exception cref="ArgumentException">נזרק כאשר הטייס אינו מוסמך לטוס במטוס F16</exception>
    private static IdfSoldier ValidPilot(IdfSoldier pilot)
    {
        if (pilot.Assignment != Assignments.Pilot)
        {
            throw new ArgumentException("The soldier must be a pilot type.");
        }
        return pilot;
    }
}
