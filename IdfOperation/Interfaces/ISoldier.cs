using IdfOperation.Idf.Constants;

namespace IdfOperation.Interfaces;

/// <summary>
/// ממשק המייצג חייל בצה"ל
/// </summary>
public interface ISoldier : INamedEntity
{
    /// <summary>
    /// דרגת החייל
    /// </summary>
    Ranks Rank { get; }

    /// <summary>
    /// תפקיד החייל בצה"ל
    /// </summary>
    Assignments Assignment { get; }
}
