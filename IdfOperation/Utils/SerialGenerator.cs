namespace IdfOperation.Utils;

/// <summary>
/// מחלקה ליצירת מזהים סידוריים ייחודיים הכוללים תאריך, קידומת ומספר רץ
/// </summary>
public class SerialGenerator
{
    /// <summary>
    /// מונה פנימי המתחיל ב־1 וגדל עם כל קריאה
    /// </summary>
    private int counter = 1;

    /// <summary>
    /// מחזיר מזהה ייחודי בפורמט: PREFIX-YYYYMMDD-#### (עם אפסים מובילים)
    /// </summary>
    /// <param name="prefix">קידומת לפי סוג הישות (ברירת מחדל: "UNIT")</param>
    /// <returns>מחרוזת ייחודית בהתאם לקידומת, תאריך ומספר רץ</returns>
    public string GetNext(string prefix = "UNIT")
    {
        string date = DateTime.Now.ToString("yyyyMMdd");
        return $"{prefix}-{date}-{counter++:D4}";
    }

    /// <summary>
    /// מאפס את המונה בחזרה ל־1 (מבלי לשנות את התאריך או הקידומת)
    /// </summary>
    public void Reset() => counter = 1;
}