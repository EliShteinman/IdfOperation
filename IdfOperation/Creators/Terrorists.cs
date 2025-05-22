using IdfOperation.Forces;
using IdfOperation.NameGenerator;
namespace IdfOperation.Creators;

// ;
public class TerroristsRandomali : ITerrorist
{
    public string Name { get; set; }
    public int Rank { get; set; }
    public bool Status { get; set; }
    public List<IWeapon> Weapons { get; set; }

    public TerroristsRandomali(HamasOperation hamas)
    {
        RandomName generator = new RandomName();
        Random r = new Random();
        this.Name = generator.GenerateName();
        this.Rank = r.Next(1, 6);
        this.Status = true;
        for (int i = 0; i < r.Next(1, 4); i++)
        {
            this.Weapons.Add(new Weapons());
        }
        hamas.Terrorists.Add(this);
    }
}
