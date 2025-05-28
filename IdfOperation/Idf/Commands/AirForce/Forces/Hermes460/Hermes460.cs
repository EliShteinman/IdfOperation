namespace IdfOperation.Idf.Commands.AirForce.Forces.Hermes460;

/// <summary>
/// מחלקה המייצגת כטב"ם הרמס 460 (זיק)
/// </summary>
public abstract class Hermes460 : Drone
{
    /// <summary>
    /// יוצר מופע חדש של כטב"ם הרמס 460
    /// </summary>
    /// <param name="name">שם הכטב"ם</param>
    /// <param name="ammunition">כמות תחמושת התחלתית (0-3)</param>
    /// <param name="fuel">כמות דלק התחלתית (0-3)</param>
    /// <param name="strikeLimit">מספר תקיפות מקסימלי במחזור (0-3)</param>
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

    /// <summary>
    /// בודק את תקינות שם הכטב"ם
    /// </summary>
    private static string ValidName(string name)
    {
        return name;
    }

    /// <summary>
    /// בודק את תקינות כמות התחמושת
    /// </summary>
    /// <exception cref="ArgumentException">נזרק כאשר כמות התחמושת אינה בטווח המותר (0-3)</exception>
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

    /// <summary>
    /// בודק את תקינות כמות הדלק
    /// </summary>
    /// <exception cref="ArgumentException">נזרק כאשר כמות הדלק אינה בטווח המותר (0-3)</exception>
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

    /// <summary>
    /// בודק את תקינות מספר התקיפות המקסימלי
    /// </summary>
    /// <exception cref="ArgumentException">נזרק כאשר מספר התקיפות אינו בטווח המותר (0-3)</exception>
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
