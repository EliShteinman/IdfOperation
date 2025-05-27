namespace IdfOperation.Interfaces;

public abstract class Organization
{
    public string Name { get; protected set; }
    public DateTime Date { get; protected set; }
    public Soldier Commander { get; protected set; }

    protected Organization(string name, DateTime date, Soldier commander)
    {
        Name = name;
        Date = date;
        Commander = commander;
    }
}