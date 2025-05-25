namespace IdfOperation.Forces.Terror;


public interface ITerrorist : ISoldier
{
    bool Status { get; set; }
    List<WeaponBase> Weapons { get; }
}