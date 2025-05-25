namespace IdfOperation.Forces;

public interface ITerrorist : ISoldier
{
    bool Status { get; set; }
    List<IWeapon> Weapons { get; set; }
}