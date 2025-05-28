using IdfOperation.Utils;

namespace IdfOperation.TerrorOrganization.Hamas.Forces;

/// <summary>
/// מחלקה המייצגת נשק אקראי
/// </summary>
public class WeaponsRandom : WeaponBase
{
    /// <summary>
    /// יוצר נשק אקראי
    /// </summary>
    public WeaponsRandom() : base(GetRandomType())
    {

    }

    /// <summary>
    /// מחזיר סוג נשק אקראי
    /// </summary>
    /// <returns>סוג נשק אקראי (סכין, אקדח, M16, או AK47)</returns>
    private static string GetRandomType()
    {
        string[] weapons = new[] { "knife", "gun", "M16", "AK47" };
        return weapons[RandomGenerators.SharedRandom.Next(weapons.Length)];
    }

    /// <summary>
    /// מחשב את ציון הנשק בהתאם לסוגו
    /// </summary>
    /// <param name="type">סוג הנשק</param>
    /// <returns>ציון הנשק (1-3)</returns>
    protected override int CalculateScore(string type)
    {
        switch (type)
        {
            case "knife":
                return 1;
            case "gun":
                return 2;
            case "M16":
                return 3;
            case "AK47":
                return 3;
            default:
                return 0;
        }
    }
}
