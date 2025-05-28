using IdfOperation.Idf.Commands.Soldiers;
using IdfOperation.Utils;

namespace IdfOperation.Idf.Commands.AirForce.Forces.F16;

/// <summary>
/// מחלקה המייצגת מטוס F16 במצב אקראי
/// </summary>
public class F16Random : F16
{
    /// <summary>
    /// יוצר מטוס F16 חדש במצב אקראי
    /// </summary>
    /// <remarks>
    /// המטוס נוצר עם:
    /// - שם אקראי
    /// - כמות תחמושת אקראית (0-8)
    /// - כמות דלק אקראית (0-8)
    /// - מספר תקיפות מקסימלי אקראי (0-8)
    /// - טייס חדש
    /// </remarks>
    public F16Random()
        : base(
            RandomGenerators.Serial.GetNext("F16"),
            RandomGenerators.SharedRandom.Next(9),
            RandomGenerators.SharedRandom.Next(9),
            RandomGenerators.SharedRandom.Next(9),
            new Pilot()
            )
    {

    }
}
