using IdfOperation.Utils;

namespace IdfOperation.Idf.Commands.GroundForces.Forces.M109;

/// <summary>
/// מחלקה המייצגת תותח M109 במצב טעון מלא
/// </summary>
public class M109FullyLoaded : M109
{
    /// <summary>
    /// יוצר תותח M109 חדש במצב טעון מלא
    /// </summary>
    /// <remarks>
    /// התותח נוצר עם:
    /// - שם אקראי
    /// - תחמושת מקסימלית (40)
    /// - דלק מקסימלי (40)
    /// - מספר תקיפות מקסימלי (40)
    /// </remarks>
    public M109FullyLoaded()
        : base(
            RandomGenerators.Serial.GetNext("M109"),
            40,
            40,
            40
        )
    {

    }
}
