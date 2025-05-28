namespace IdfOperation.Interfaces;

/// <summary>
/// ממשק המייצג ארגון
/// </summary>
public interface IOrganization
{
    /// <summary>
    /// שם הארגון
    /// </summary>
    string Name { get; }

    /// <summary>
    /// תאריך הקמת הארגון
    /// </summary>
    DateTime Date { get; }
}
