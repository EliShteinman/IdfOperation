using IdfOperation.Interfaces;
using IdfOperation.TerrorOrganization.Terror;

namespace IdfOperation.TerrorOrganization;

public class TerrorOrg : IOrganization
{
    public string Name { get; private set; }
    public DateTime Date { get; private set; }
    public Soldier Commander { get; private set; }
    public List<Terrorist> Terrorists { get; set; }

    public TerrorOrg(string name, Terrorist commander, DateTime date)
    {
        Name = name;
        Date = date;
        Commander = commander;

        Terrorists = new List<Terrorist>() { commander };
    }
}