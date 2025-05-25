using IdfOperation.Forces.Terror;
using IdfOperation.Forces;

namespace IdfOperation.Organization;
public class TerrorOrg : IOrganization
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public ISoldier Commander { get; set; }
    public List<Terrorist> Terrorists { get; set; } = new List<Terrorist>();
}
