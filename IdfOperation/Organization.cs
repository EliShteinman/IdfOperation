using IdfOperation.Forces;

namespace IdfOperation;

public class Organization
{
    protected string Name;
    protected DateTime Date;
    protected ISoldier Commander;
    
}

public class IdfOperation : Organization
{
    private List<ICombatUnit> Soldiers;
}

public class HamasOperation: Organization
{
    private List<ITerrorist> Terrorists;
}