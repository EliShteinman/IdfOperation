using IdfOperation.Forces;

namespace IdfOperation.Organization;

public interface Organization
{
    string Name { get; set; }
    DateTime Date { get; set; }
    ISoldier Commander { get; set; }

}

