using IdfOperation.Interfaces;

namespace IdfOperation.Idf.Constants;

/// <summary>
/// מחלקה בסיסית המייצגת חייל בצה"ל
/// </summary>
public abstract class IdfSoldier : ISoldier
{
    /// <summary>
    /// שם החייל
    /// </summary>
    public string Name { get; protected set; }

    /// <summary>
    /// דרגת החייל
    /// </summary>
    public Ranks Rank { get; protected set; }    // public string Assignment { get; protected set; }

    /// <summary>
    /// תפקיד החייל
    /// </summary>
    public Assignments Assignment { get; protected set; }


    /// <summary>
    /// יוצר חייל חדש
    /// </summary>
    /// <param name="name">שם החייל</param>
    /// <param name="rank">דרגת החייל</param>
    /// <param name="assignment">תפקיד החייל</param>
    protected IdfSoldier(string name, Ranks rank, Assignments assignment)
    {
        Name = name;
        Rank = rank;
        Assignment = assignment;
    }
}
