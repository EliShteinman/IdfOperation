using IdfOperation.NameGenerator;
using IdfOperation.Creators;
using IdfOperation.Organization;
namespace IdfOperation.Forces.Terror;

// ;
public class TerroristRandomali : Terrorist
{
    private static readonly Random SharedRandom = new Random();
    public TerroristRandomali(Organization.Terror terror)
        : base(
            new RandomName().GenerateName(),
            SharedRandom.Next(1, 6),
            true,
            GenerateWeapons()
            )

    {
        terror.Terrorists.Add(this);
    }

    private static List<WeaponBase> GenerateWeapons()
    {
        List<WeaponBase> list = new List<WeaponBase>();
        for (int i = 0; i < SharedRandom.Next(1, 5); i++)
        {
            list.Add(new WeaponsRandom());
        }
        return list;
    }
}
