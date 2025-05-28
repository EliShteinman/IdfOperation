using IdfOperation.Interfaces;

namespace IdfOperation.TerrorOrganization.Hamas.Forces;

/// <summary>
/// מחלקה בסיסית המייצגת טרוריסט
/// </summary>
public abstract class Terrorist : ITerrorist
{
    /// <summary>
    /// שם הטרוריסט
    /// </summary>
    public string Name { get; protected set; }

    /// <summary>
    /// דרגת הטרוריסט
    /// </summary>
    public int Rank { get; set; }

    /// <summary>
    /// סטטוס הטרוריסט (חי/מת)
    /// </summary>
    public bool Status { get; set; }

    /// <summary>
    /// רשימת הנשקים שברשות הטרוריסט
    /// </summary>
    public List<WeaponBase> Weapons { get; protected set; }

    /// <summary>
    /// יוצר טרוריסט חדש
    /// </summary>
    /// <param name="name">שם הטרוריסט</param>
    /// <param name="rank">דרגת הטרוריסט</param>
    /// <param name="status">סטטוס הטרוריסט</param>
    /// <param name="weapons">רשימת הנשקים שברשות הטרוריסט</param>
    protected Terrorist(string name, int rank, bool status, List<WeaponBase> weapons)
    {
        Name = name;
        Rank = rank;
        Status = status;
        Weapons = weapons;
    }
}
