using IdfOperation.Organization;
using IdfOperation.Utils;
namespace IdfOperation.Forces.Terror;


public class TerroristRandomizer : Terrorist
{
    public TerroristRandomizer(TerrorOrg terror)
        : base(
            RandomGenerators.NameRandom.GenerateName(),
            RandomGenerators.SharedRandom.Next(1, 6),
            true,
            GenerateWeapons()
            )

    {
        terror.Terrorists.Add(this);
    }

    private static List<WeaponBase> GenerateWeapons()
    {
        List<WeaponBase> list = new List<WeaponBase>();
        for (int i = 0; i < RandomGenerators.SharedRandom.Next(1, 5); i++)
        {
            list.Add(new WeaponsRandom());
        }
        return list;
    }
}
