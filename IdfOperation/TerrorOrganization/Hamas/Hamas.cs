using IdfOperation.Interfaces;
using IdfOperation.TerrorOrganization.Hamas.Forces;

namespace IdfOperation.TerrorOrganization.Hamas;

/// <summary>
/// מחלקה המייצגת את ארגון חמאס
/// </summary>
public class Hamas : IOrganization
{
    private static Hamas _instance;

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
    public ITerrorist Commander { get; private set; }

    /// <summary>
    /// רשימת הטרוריסטים בארגון
    /// </summary>
    public List<ITerrorist> Terrorists { get; set; }

    /// <summary>
    /// יוצר מופע חדש של ארגון חמאס
    /// </summary>
    /// <param name="name">שם הארגון</param>
    /// <param name="commander">מפקד הארגון</param>
    /// <param name="date">תאריך הקמת הארגון</param>
    private Hamas(string name, Terrorist commander, DateTime date)
    {
        Name = name;
        Date = date;
        Commander = commander;
        Terrorists = new List<ITerrorist> { commander };
    }

    /// <summary>
    /// יוצר מופע חדש של ארגון חמאס (Singleton)
    /// </summary>
    /// <param name="name">שם הארגון</param>
    /// <param name="commander">מפקד הארגון</param>
    /// <param name="date">תאריך הקמת הארגון</param>
    /// <returns>המופע היחיד של ארגון חמאס</returns>
    public static Hamas CreateInstance(string name, Terrorist commander, DateTime date)
    {
        if (_instance == null)
        {
            _instance = new Hamas(name, commander, date);
        }
        return _instance;
    }

    /// <summary>
    /// מחזיר את המופע היחיד של ארגון חמאס
    /// </summary>
    /// <exception cref="InvalidOperationException">נזרק כאשר לא נוצר מופע של הארגון</exception>
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
