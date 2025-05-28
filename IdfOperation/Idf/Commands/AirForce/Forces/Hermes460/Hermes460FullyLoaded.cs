using IdfOperation.Utils;

namespace IdfOperation.Idf.Commands.AirForce.Forces.Hermes460;

/// <summary>
/// מחלקה המייצגת כטב"ם הרמס 460 במצב טעון מלא
/// </summary>
internal class Hermes460FullyLoaded : Hermes460
{
    /// <summary>
    /// יוצר כטב"ם הרמס 460 חדש במצב טעון מלא
    /// </summary>
    /// <remarks>
    /// הכטב"ם נוצר עם:
    /// - תחמושת מקסימלית (3)
    /// - דלק מקסימלי (3)
    /// - מספר תקיפות מקסימלי (3)
    /// </remarks>
    public Hermes460FullyLoaded()
        : base(
            RandomGenerators.Serial.GetNext("Hermes460"),
            3,
            3,
            3
        )
    {
    }
}
