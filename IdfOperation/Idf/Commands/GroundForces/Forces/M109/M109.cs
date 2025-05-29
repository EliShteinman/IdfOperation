namespace IdfOperation.Idf.Commands.GroundForces.Forces.M109;

/// <summary>
/// מחלקה המייצגת תותח M109
/// </summary>
public abstract class M109 : Artillery
{
    /// <summary>
    /// יוצר מופע חדש של תותח M109
    /// </summary>
    /// <param name="name">שם התותח</param>
    /// <param name="ammunition">כמות תחמושת התחלתית (0-40)</param>
    /// <param name="fuel">כמות דלק התחלתית (0-40)</param>
    /// <param name="strikeLimit">מספר תקיפות מקסימלי במחזור (0-40)</param>
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

    /// <summary>
    /// בודק את תקינות שם התותח
    /// </summary>
    private static string ValidName(string name)
    {
        return name;
    }

    /// <summary>
    /// בודק את תקינות כמות התחמושת
    /// </summary>
    /// <exception cref="ArgumentException">נזרק כאשר כמות התחמושת אינה בטווח המותר (0-40)</exception>
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

    /// <summary>
    /// בודק את תקינות כמות הדלק
    /// </summary>
    /// <exception cref="ArgumentException">נזרק כאשר כמות הדלק אינה בטווח המותר (0-40)</exception>
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

    /// <summary>
    /// בודק את תקינות מספר התקיפות המקסימלי
    /// </summary>
    /// <exception cref="ArgumentException">נזרק כאשר מספר התקיפות אינו בטווח המותר (0-40)</exception>
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
