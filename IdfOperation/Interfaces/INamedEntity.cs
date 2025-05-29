namespace IdfOperation.Interfaces;

/// <summary>
/// ממשק בסיסי המייצג ישות בעלת שם
/// </summary>
public interface INamedEntity
{
    /// <summary>
    /// השם של הישות
    /// </summary>
    string Name { get; }
}

