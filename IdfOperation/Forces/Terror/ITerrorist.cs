namespace IdfOperation.Forces.Terror;


public interface ITerrorist : ISoldier
{
    int Rank { get; set; }
    bool Status { get; set; }
    List<WeaponBase> Weapons { get; }
}