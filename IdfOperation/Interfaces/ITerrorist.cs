using IdfOperation.TerrorOrganization.Hamas.Forces;
namespace IdfOperation.Interfaces;

public interface ITerrorist : INamedEntity
{
    int Rank { get; }
    bool Status { get; set; }
    List<WeaponBase> Weapons { get; }
}