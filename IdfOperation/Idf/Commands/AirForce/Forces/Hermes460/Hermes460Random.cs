using IdfOperation.Utils;

namespace IdfOperation.Idf.Commands.AirForce.Forces.Hermes460;

/// <summary>
/// מחלקה המייצגת כטב"ם הרמס 460 במצב אקראי
/// </summary>
public class Hermes460Random : Hermes460
{
    /// <summary>
    /// יוצר כטב"ם הרמס 460 חדש במצב אקראי
    /// </summary>
    /// <remarks>
    /// הכטב"ם נוצר עם:
    /// - שם אקראי
    /// - כמות תחמושת אקראית (0-3)
    /// - כמות דלק אקראית (0-3)
    /// - מספר תקיפות מקסימלי אקראי (0-3)
    /// </remarks>
    public Hermes460Random()
        : base(
            RandomGenerators.Serial.GetNext("Hermes460"),
            RandomGenerators.SharedRandom.Next(4),
            RandomGenerators.SharedRandom.Next(4),
            RandomGenerators.SharedRandom.Next(4)
        )
    {

    }
}
