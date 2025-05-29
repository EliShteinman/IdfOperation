using IdfOperation.Utils;
using IdfOperation.Idf.Constants;

namespace IdfOperation.Idf.Commands.Soldiers;

/// <summary>
/// מחלקה המייצגת חייל בצה"ל עם מאפיינים אקראיים
/// </summary>
public class SoldierRandomized : IdfSoldier
{
    /// <summary>
    /// מערך של כל הדרגות האפשריות בצה"ל
    /// </summary>
    private static Ranks[] allRanks = (Ranks[])Enum.GetValues(typeof(Ranks));

    /// <summary>
    /// מערך של כל התפקידים האפשריים בצה"ל
    /// </summary>
    private static Assignments[] allAssignments = (Assignments[])Enum.GetValues(typeof(Assignments));

    /// <summary>
    /// יוצר חייל חדש עם מאפיינים אקראיים
    /// </summary>
    /// <remarks>
    /// החייל נוצר עם:
    /// - שם אקראי
    /// - דרגה אקראית
    /// - תפקיד אקראי
    /// </remarks>
    public SoldierRandomized()
        : base(
            RandomGenerators.NameRandom.GenerateName(),
            allRanks[RandomGenerators.SharedRandom.Next(allRanks.Length)],
            allAssignments[RandomGenerators.SharedRandom.Next(allAssignments.Length)])
    {

    }
}
