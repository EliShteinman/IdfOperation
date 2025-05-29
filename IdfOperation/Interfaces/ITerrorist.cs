using IdfOperation.TerrorOrganization.Hamas.Forces;
namespace IdfOperation.Interfaces;

/// <summary>
/// ממשק המייצג טרוריסט בארגון חמאס
/// </summary>
public interface ITerrorist : INamedEntity
{
    /// <summary>
    /// דרגת הטרוריסט (1-5)
    /// </summary>
    int Rank { get; }

    /// <summary>
    /// סטטוס הטרוריסט (חי/מת)
    /// </summary>
    bool Status { get; set; }

    /// <summary>
    /// רשימת הנשקים שברשות הטרוריסט
    /// </summary>
    List<WeaponBase> Weapons { get; }
}
