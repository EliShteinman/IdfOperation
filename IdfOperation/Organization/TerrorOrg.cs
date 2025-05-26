using IdfOperation.Forces.Terror;
using IdfOperation.Forces;

namespace IdfOperation.Organization;

public class TerrorOrg : Organization
{
    public List<Terrorist> Terrorists { get; set; }

    public TerrorOrg(string name, Terrorist commander, DateTime date)
        : base(name, date, commander)
    {
        this.Terrorists = new List<Terrorist>() { commander };
    }
}