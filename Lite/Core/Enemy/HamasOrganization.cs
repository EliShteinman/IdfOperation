namespace Lite.Core.Enemy;

public class HamasOrganization
{
    private static HamasOrganization? _instance;
    public string Name { get; private set; }
    public DateTime Date { get; private set; }
    public List<TerroristBase> Members { get; private set; }
    public TerroristBase Leader { get; private set; }

    private HamasOrganization(string name, DateTime date, TerroristBase leader)
    {
        Name = ValidName(name);
        Date = date;
        Leader = leader;
        Members = [];
    }
    private static string ValidName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name required");
        }
        return name;
    }

    public static HamasOrganization CreateInstance(string name, DateTime date, TerroristBase leader)
    {
        if (_instance == null)
        {
            _instance = new HamasOrganization(name, date, leader);
        }
        return _instance;
    }

    public static HamasOrganization Instance
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

    public void AddMember(TerroristBase terrorist)
    {
        Members.Add(terrorist);
    }
}