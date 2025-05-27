using IdfOperation.Interfaces;

namespace IdfOperation.TerrorOrganization.Hamas.Forces;

public abstract class Terrorist : ITerrorist
{
    public string Name { get; protected set; }
    public int Rank { get; set; }
    public bool Status { get; set; }
    public List<WeaponBase> Weapons { get; protected set; }

    protected Terrorist(string name, int rank, bool status, List<WeaponBase> weapons)
    {
        Name = name;
        Rank = rank;
        Status = status;
        Weapons = weapons;
    }
}