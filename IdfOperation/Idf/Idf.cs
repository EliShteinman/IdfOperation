using IdfOperation.Idf.Constants;
using IdfOperation.Interfaces;
using IdfOperation.Lite.Domain.Contracts;

namespace IdfOperation.Idf;

/// <summary>
/// מחלקה המייצגת את צה"ל
/// </summary>
public class Idf : IOrganization
{
    private static Idf _instance;

    /// <summary>
    /// שם הארגון
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// תאריך הקמת הארגון
    /// </summary>
    public DateTime Date { get; private set; }

    /// <summary>
    /// מפקד הארגון
    /// </summary>
    public ISoldier Commander { get; private set; }

    /// <summary>
    /// רשימת יחידות התקיפה בצה"ל
    /// </summary>
    public List<StrikeUnit1> StrikeUnits { get; set; }

    /// <summary>
    /// רשימת החיילים בצה"ל
    /// </summary>
    public List<IdfSoldier> IdfSoldiers { get; set; }

    /// <summary>
    /// יוצר מופע חדש של צה"ל
    /// </summary>
    /// <param name="name">שם הארגון</param>
    /// <param name="commander">מפקד הארגון</param>
    /// <param name="date">תאריך הקמת הארגון</param>
    private Idf(string name, IdfSoldier commander, DateTime date)
    {
        Name = name;
        Date = date;
        Commander = commander;

        StrikeUnits = new List<StrikeUnit1>();
        IdfSoldiers = new List<IdfSoldier>() { commander };
    }

    /// <summary>
    /// יוצר מופע חדש של צה"ל (Singleton)
    /// </summary>
    /// <param name="name">שם הארגון</param>
    /// <param name="commander">מפקד הארגון</param>
    /// <param name="date">תאריך הקמת הארגון</param>
    /// <returns>המופע היחיד של צה"ל</returns>
    public static Idf CreateInstance(string name, IdfSoldier commander, DateTime date)
    {
        if (_instance == null)
            _instance = new Idf(name, commander, date);
        return _instance;
    }

    /// <summary>
    /// מחזיר את המופע היחיד של צה"ל
    /// </summary>
    /// <exception cref="InvalidOperationException">נזרק כאשר לא נוצר מופע של הארגון</exception>
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
