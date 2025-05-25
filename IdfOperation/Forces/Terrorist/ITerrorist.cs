namespace IdfOperation.Forces;

public interface ITerrorist : ISoldier
{
    bool Status { get; set; }
    List<WeaponBase> Weapons { get; set; }
}