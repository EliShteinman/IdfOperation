using IdfOperation.Idf.Constants;
using IdfOperation.Lite.Domain.Enum;
using IdfOperation.Utils;

namespace IdfOperation.Idf.Commands.Soldiers;

/// <summary>
/// מחלקה המייצגת טייס בצה"ל
/// </summary>
public class Pilot : IdfSoldier
{
    /// <summary>
    /// מערך של הדרגות האפשריות לטייסים בצה"ל
    /// </summary>
    private static readonly Ranks[] PilotRanks =
    [
        Ranks.Capt,
        Ranks.Maj,
        Ranks.LtCol,
        Ranks.Col,
        Ranks.MajGen
    ];

    /// <summary>
    /// מחזיר דרגה אקראית מהדרגות האפשריות לטייסים
    /// </summary>
    /// <returns>דרגה אקראית מהדרגות האפשריות לטייסים</returns>
    private static Ranks GetRandomPilotRank()
    {
        return PilotRanks[RandomGenerators.SharedRandom.Next(PilotRanks.Length)];
    }

    /// <summary>
    /// יוצר טייס חדש
    /// </summary>
    /// <remarks>
    /// הטייס נוצר עם:
    /// - שם אקראי
    /// - דרגה אקראית מהדרגות האפשריות לטייסים
    /// - תפקיד: טייס
    /// </remarks>
    public Pilot()
        : base(
            RandomGenerators.NameRandom.GenerateName(),
            GetRandomPilotRank(),
            Assignments.Pilot)
    {

    }
}
