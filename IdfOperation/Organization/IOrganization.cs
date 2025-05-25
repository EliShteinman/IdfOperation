using IdfOperation.Forces;

namespace IdfOperation.Organization;

public interface IOrganization
{
    string Name { get; set; }
    DateTime Date { get; set; }
    ISoldier Commander { get; set; }

}

