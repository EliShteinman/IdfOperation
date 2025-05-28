using IdfOperation.TerrorOrganization.Hamas.Forces;
using IdfOperation.Utils;

namespace IdfOperation.Idf.Commands.Intelligence;

/// <summary>
/// מחלקה האחראית על יצירת הודעות מודיעין
/// </summary>
internal class MessageCreating : Message
{
    /// <summary>
    /// יוצר מופע חדש של הודעת מודיעין
    /// </summary>
    /// <param name="terrorist">הטרוריסט שאליו מתייחסת ההודעה</param>
    /// <param name="zone">האזור בו נצפה הטרוריסט</param>
    /// <param name="date">תאריך ושעת ההודעה</param>
    public MessageCreating(Terrorist terrorist, string zone, DateTime date)
        : base(terrorist, zone, date)
    {
    }
}
