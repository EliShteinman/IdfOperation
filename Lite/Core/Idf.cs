using Lite.Core.Contracts;
using Lite.Core.Enum;

namespace Lite.Core;

public class Idf
{
    private static Idf _instance;
    public string Name { get; private set; }
    public DateTime Date { get; private set; }
    public List<IStrikeUnit> StrikeUnits { get; private set; }
    public ISoldier Commander { get; private set; }

    private Idf(string name, DateTime date, ISoldier commander)
    {
        Name = ValidName(name);
        Date = date;
        Commander = ValidCommander(commander);
        StrikeUnits = [];
    }

    private static ISoldier ValidCommander(ISoldier commander)
    {
        if (commander.Assignment != Assignments.ChiefOfStaff)
        {
            throw new ArgumentException("Commander must be ChiefOfStaff");
        }
        return commander;
    }

    private static string ValidName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name required");
        }
        return name;
    }
    public static Idf CreateInstance(string name, DateTime date, ISoldier commander)
    {
        if (_instance == null)
        {
            _instance = new Idf(name, date, commander);
        }
        return _instance;
    }

    public static Idf Instance
    {
        get
        {
            if (_instance == null)
            {
                throw new InvalidOperationException("Must call CreateInstance(...) before accessing the instance.");
            }
            return _instance;
        }
    }
}