namespace IdfOperation.Forces.Terror;

public abstract class Terrorist : Soldier
{
    public string Name { get; set; }
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