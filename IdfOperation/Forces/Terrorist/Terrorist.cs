namespace IdfOperation.Forces;

public abstract class Terrorist : ITerrorist
{
    public string Name { get; set; }
    public int Rank { get; set; }
    public bool Status { get; set; }
    public List<WeaponBase> Weapons { get; set; }
    protected Terrorist(string name, int rank, bool status, List<WeaponBase> weapons)
    {
        Name = name;
        Rank = rank;
        Status = status;
        Weapons = weapons;
    }
}