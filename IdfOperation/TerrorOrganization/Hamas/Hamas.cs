using IdfOperation.Interfaces;
using IdfOperation.TerrorOrganization.Hamas.Forces;

namespace IdfOperation.TerrorOrganization.Hamas;

public class Hamas : IOrganization
{
    private static Hamas _instance;
    public string Name { get; private set; }
    public DateTime Date { get; private set; }
    public ITerrorist Commander { get; private set; }
    public List<ITerrorist> Terrorists { get; set; }

    private Hamas(string name, Terrorist commander, DateTime date)
    {
        Name = name;
        Date = date;
        Commander = commander;

        Terrorists = new List<ITerrorist> { commander };
    }

    public static Hamas CreateInstance(string name, Terrorist commander, DateTime date)
    {
        if (_instance == null)
        {
            _instance = new Hamas(name, commander, date);
        }

        return _instance;
    }

    public static Hamas Instance
    {
        get
        {
            if (_instance == null)
                throw new InvalidOperationException("Must call CreateInstance(...) before accessing the instance.");

            return _instance;
        }
    }
}