using IdfOperation.Forces;
using IdfOperation.NameGenerator;
namespace IdfOperation.Creators;

// ;
public class TerroristsRandomali : Terrorist
{
    public TerroristsRandomali(HamasOperation hamas)
        : base(
            new RandomName().GenerateName(),
            new Random().Next(1, 6),
            true,
            GenerateWeapons()
            )
    
    {
        hamas.Terrorists.Add(this);
    }

    private static List<WeaponBase> GenerateWeapons()
    {
        List<WeaponBase> list = new List<WeaponBase>();
        Random r = new Random();
        for (int i = 0; i < r.Next(1, 4); i++)
        {
            list.Add(new WeaponsRandom());
        }
        return list;
    }
}
