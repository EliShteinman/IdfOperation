using IdfOperation.Utils.NameGenerator;

namespace IdfOperation.Utils;

/// <summary>
/// מחלקה סטטית המכילה גנרטורים אקראיים לשימוש בכל המערכת
/// </summary>
public static class RandomGenerators
{
    /// <summary>
    /// מופע אקראי משותף לשימוש בכל המערכת
    /// </summary>
    public static readonly Random SharedRandom = new Random();

    /// <summary>
    /// גנרטור שמות אקראיים
    /// </summary>
    public static readonly RandomName NameRandom = new RandomName();

    /// <summary>
    /// גנרטור מספרים סידוריים
    /// </summary>
    public static readonly SerialGenerator Serial = new();
}
