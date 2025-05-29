using IdfOperation.Idf.Commands.Soldiers;
using IdfOperation.Utils;

namespace IdfOperation.Idf.Commands.AirForce.Forces.F16;

/// <summary>
/// מחלקה המייצגת מטוס F16 במצב טעון מלא
/// </summary>
public class F16FullyLoaded : F16
{
    /// <summary>
    /// יוצר מטוס F16 חדש במצב טעון מלא
    /// </summary>
    /// <remarks>
    /// המטוס נוצר עם:
    /// - שם אקראי
    /// - תחמושת מקסימלית (8)
    /// - דלק מקסימלי (8)
    /// - מספר תקיפות מקסימלי (8)
    /// - טייס חדש
    /// </remarks>
    public F16FullyLoaded()
        : base(
            RandomGenerators.Serial.GetNext("F16"),
            8,
            8,
            8,
            new Pilot()
        )
    {

    }
}
