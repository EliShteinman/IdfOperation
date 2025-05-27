using IdfOperation.Utils;

namespace IdfOperation.TerrorOrganization.Terror;


public class TerroristRandomizer : Terrorist
{
    public TerroristRandomizer()
        : base(
            RandomGenerators.NameRandom.GenerateName(),
            RandomGenerators.SharedRandom.Next(1, 6),
            true,
            GenerateWeapons()
            )
    {
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
