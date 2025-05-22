using IdfOperation.Forces;

namespace IdfOperation;

public interface Organization
{
    protected string Name {get; set;}
    protected DateTime Date {get; set;}
    protected ISoldier Commander {get; set;}
    
}

