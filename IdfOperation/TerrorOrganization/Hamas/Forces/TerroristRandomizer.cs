using IdfOperation.Utils;

namespace IdfOperation.TerrorOrganization.Hamas.Forces;

/// <summary>
/// מחלקה המייצגת טרוריסט עם מאפיינים אקראיים
/// </summary>
public class TerroristRandomizer : Terrorist
{
    /// <summary>
    /// יוצר טרוריסט חדש עם מאפיינים אקראיים
    /// </summary>
    /// <remarks>
    /// הטרוריסט נוצר עם:
    /// - שם אקראי
    /// - דרגה אקראית (1-5)
    /// - סטטוס: חי
    /// - רשימת נשקים אקראית (1-4 נשקים)
    /// </remarks>
    public TerroristRandomizer()
        : base(
            RandomGenerators.NameRandom.GenerateName(),
            RandomGenerators.SharedRandom.Next(1, 6),
            true,
            GenerateWeapons()
            )
    {
    }

    /// <summary>
    /// יוצר רשימת נשקים אקראית
    /// </summary>
    /// <returns>רשימת נשקים אקראית (1-4 נשקים)</returns>
    private static List<WeaponBase> GenerateWeapons()
    {
        List<WeaponBase> list = new List<WeaponBase>();
        for (int i = 0; i < RandomGenerators.SharedRandom.Next(1, 5); i++)
        {
            list.Add(new WeaponsRandom());
        }
        return list;
    }
}
