using IdfOperation.Interfaces;

namespace IdfOperation.Idf;

public class Idf : IOrganization
{
    private static Idf _instance;
    public string Name { get; private set; }
    public DateTime Date { get; private set; }
    public ISoldier Commander { get; private set; }


    public List<StrikeUnit> StrikeUnits { get; set; }
    public List<IdfSoldier> IdfSoldiers { get; set; }

    private Idf(string name, IdfSoldier commander, DateTime date)
    {
        Name = name;
        Date = date;
        Commander = commander;

        StrikeUnits = new List<StrikeUnit>();
        IdfSoldiers = new List<IdfSoldier>() { commander };
    }

    public static Idf CreateInstance(string name, IdfSoldier commander, DateTime date)
    {

        if (_instance == null)
            _instance = new Idf(name, commander, date);
        return _instance;

    }
    public static Idf Instance
    {
        get
        {
            if (_instance == null)
                throw new InvalidOperationException("Must call CreateInstance(...) before accessing the instance.");

            return _instance;
        }
    }
}