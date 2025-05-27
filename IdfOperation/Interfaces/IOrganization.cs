namespace IdfOperation.Interfaces;

public interface IOrganization
{
    string Name { get;}
    DateTime Date { get;  }
    Soldier Commander { get;  }
}