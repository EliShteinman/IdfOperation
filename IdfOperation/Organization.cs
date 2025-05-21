using IdfOperation.Forces;

namespace IdfOperation;

public class Organization
{
    protected string Name;
    protected DateTime Date;
    protected ISoldier Commander;
    protected List<ICombatUnit> Soldiers;
    
}

