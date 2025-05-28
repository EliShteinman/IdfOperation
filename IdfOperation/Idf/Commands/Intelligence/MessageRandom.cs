using IdfOperation.TerrorOrganization.Hamas;
using IdfOperation.Utils;
using IdfOperation.Interfaces;

namespace IdfOperation.Idf.Commands.Intelligence;

/// <summary>
/// מחלקה האחראית על יצירת הודעות מודיעין אקראיות
/// </summary>
internal class MessageRandom : Message
{
    /// <summary>
    /// יוצר הודעת מודיעין אקראית
    /// </summary>
    /// <param name="hamas">ארגון חמאס שממנו ייבחר טרוריסט אקראי</param>
    /// <exception cref="ArgumentException">נזרק כאשר אין טרוריסטים בארגון</exception>
    public MessageRandom(Hamas hamas)
        : base(
            GetTerrorist(hamas),
            GetZone(),
            GetDateTime()
        )
    {
        if (hamas.Terrorists.Count == 0)
            throw new ArgumentException("No terrorists found in the operation.");
    }

    /// <summary>
    /// בוחר טרוריסט אקראי מארגון חמאס
    /// </summary>
    /// <param name="hamas">ארגון חמאס</param>
    /// <returns>טרוריסט שנבחר באופן אקראי</returns>
    private static ITerrorist GetTerrorist(Hamas hamas)
    {
        return hamas.Terrorists[RandomGenerators.SharedRandom.Next(hamas.Terrorists.Count)];
    }

    /// <summary>
    /// מחזיר מיקום אקראי מתוך רשימת המיקומים האפשריים
    /// </summary>
    /// <returns>שם המיקום שנבחר</returns>
    private static string GetZone()
    {
        string[] zones = new[] { "At home", "By car", "On the street" };
        return zones[RandomGenerators.SharedRandom.Next(zones.Length)];
    }

    /// <summary>
    /// מחזיר תאריך אקראי בין תחילת 2023 להיום
    /// </summary>
    /// <returns>תאריך שנבחר באופן אקראי</returns>
    private static DateTime GetDateTime()
    {
        DateTime start = new DateTime(2023, 1, 1);
        int range = (DateTime.Today - start).Days;
        return start.AddDays(RandomGenerators.SharedRandom.Next(range));
    }
}
