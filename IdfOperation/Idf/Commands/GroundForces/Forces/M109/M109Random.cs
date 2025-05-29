using IdfOperation.Utils;

namespace IdfOperation.Idf.Commands.GroundForces.Forces.M109;

/// <summary>
/// מחלקה המייצגת תותח M109 במצב אקראי
/// </summary>
public class M109Random : M109
{
    /// <summary>
    /// יוצר תותח M109 חדש במצב אקראי
    /// </summary>
    /// <remarks>
    /// התותח נוצר עם:
    /// - שם אקראי
    /// - כמות תחמושת אקראית (0-40)
    /// - כמות דלק אקראית (0-40)
    /// - מספר תקיפות מקסימלי אקראי (0-40)
    /// </remarks>
    public M109Random()
        : base(
            RandomGenerators.Serial.GetNext("M109"),
            RandomGenerators.SharedRandom.Next(41),
            RandomGenerators.SharedRandom.Next(41),
            RandomGenerators.SharedRandom.Next(41)
        )
    {

    }
}
