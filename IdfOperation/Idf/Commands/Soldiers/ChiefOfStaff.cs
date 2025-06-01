using IdfOperation.Idf.Constants;
using IdfOperation.Lite.Domain.Enum;

namespace IdfOperation.Idf.Commands.Soldiers;

/// <summary>
/// מחלקה המייצגת את ראש המטה הכללי של צה"ל
/// </summary>
public class ChiefOfStaff : IdfSoldier
{
    /// <summary>
    /// יוצר מופע חדש של ראש המטה הכללי
    /// </summary>
    /// <remarks>
    /// נוצר עם:
    /// - שם: אייל זמיר
    /// - דרגה: אלוף
    /// - תפקיד: ראש המטה הכללי
    /// </remarks>
    public ChiefOfStaff()
        : base(
            "Eyal Zamir",
            Ranks.LtGen,
            Assignments.ChiefOfStaff
            )
    {

    }

}
