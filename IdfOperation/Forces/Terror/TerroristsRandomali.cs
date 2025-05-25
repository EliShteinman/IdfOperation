using IdfOperation.NameGenerator;
using IdfOperation.Creators;
namespace IdfOperation.Forces.Terror;

// ;
public class TerroristsRandomali : Terrorist
{
    private static readonly Random _random = new Random();
    public TerroristsRandomali(TerrorOperation terror)
        : base(
            new RandomName().GenerateName(),
            _random.Next(1, 6),
            true,
            GenerateWeapons()
            )
    
    {
        terror.Terrorists.Add(this);
    }

    private static List<WeaponBase> GenerateWeapons()
    {
        List<WeaponBase> list = new List<WeaponBase>();
        for (int i = 0; i < _random.Next(1, 5); i++)
        {
            list.Add(new WeaponsRandom());
        }
        return list;
    }
}
