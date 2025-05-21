namespace IdfOperation.Forces;

public interface ITerrorist: ISoldier
{
    bool Status { get; }
    List<IWeapon> Weapons { get; }
}