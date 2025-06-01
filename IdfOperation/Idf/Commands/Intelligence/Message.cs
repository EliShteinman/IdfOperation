using IdfOperation.Interfaces;
using IdfOperation.Lite.Domain.Contracts;
using IdfOperation.TerrorOrganization.Hamas.Forces;

namespace IdfOperation.Idf.Commands.Intelligence;

/// <summary>
/// מחלקה בסיסית המייצגת הודעת מודיעין
/// </summary>
public abstract class Message
{
    /// <summary>
    /// הטרוריסט שאליו מתייחסת ההודעה
    /// </summary>
    public ITerrorist Terrorist { get; protected set; }

    /// <summary>
    /// האזור שבו נצפה הטרוריסט
    /// </summary>
    public string Zone { get; protected set; }

    /// <summary>
    /// תאריך ושעת ההודעה
    /// </summary>
    public DateTime Date { get; protected set; }

    /// <summary>
    /// יוצר הודעת מודיעין חדשה
    /// </summary>
    /// <param name="terrorist">הטרוריסט שאליו מתייחסת ההודעה</param>
    /// <param name="zone">האזור שבו נצפה הטרוריסט</param>
    /// <param name="date">תאריך ושעת ההודעה</param>
    protected Message(ITerrorist terrorist, string zone, DateTime date)
    {
        Terrorist = terrorist;
        Zone = zone;
        Date = date;
    }
}
