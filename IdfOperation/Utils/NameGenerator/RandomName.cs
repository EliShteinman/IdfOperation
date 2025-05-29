using Newtonsoft.Json;

namespace IdfOperation.Utils.NameGenerator;

/// <summary>
/// מחלקה המאפשרת יצירה אקראית של שמות פרטיים ומשפחה
/// </summary>
public class RandomName
{
    /// <summary>
    /// מחולל מספרים אקראיים
    /// </summary>
    private readonly Random rand = new();

    /// <summary>
    /// רשימת שמות פרטיים זכריים
    /// </summary>
    private readonly List<string> Male;

    /// <summary>
    /// רשימת שמות פרטיים נקביים
    /// </summary>
    private readonly List<string> Female;

    /// <summary>
    /// רשימת שמות משפחה
    /// </summary>
    private readonly List<string> Last;

    /// <summary>
    /// מחלקה פנימית המשמשת כמודל לקריאת קובץ ה־JSON עם רשימות שמות
    /// </summary>
    private class NameList
    {
        /// <summary>
        /// שמות פרטיים זכריים
        /// </summary>
        public string[] boys { get; set; }

        /// <summary>
        /// שמות פרטיים נקביים
        /// </summary>
        public string[] girls { get; set; }

        /// <summary>
        /// שמות משפחה
        /// </summary>
        public string[] last { get; set; }
    }

    /// <summary>
    /// פעולה בונה אשר טוענת את קובץ ה־JSON עם רשימות השמות מהתיקייה המקומית של הפרויקט
    /// </summary>
    public RandomName()
    {
        // טוען את הקובץ ישירות מהתיקייה שלך בפרויקט
        string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "NameGenerator", "names.json");
        path = Path.GetFullPath(path);
        var serializer = new JsonSerializer();

        NameList names;
        using (StreamReader reader = new(path))
        using (JsonReader jreader = new JsonTextReader(reader))
        {
            names = serializer.Deserialize<NameList>(jreader);
        }

        Male = new List<string>(names.boys);
        Female = new List<string>(names.girls);
        Last = new List<string>(names.last);
    }

    /// <summary>
    /// יוצר שם אקראי בהתאם להגדרות שסופקו
    /// </summary>
    /// <param name="male">האם ליצור שם זכרי (true) או נקבי (false)</param>
    /// <param name="middleCount">כמות שמות אמצעיים (ניתן לאפס)</param>
    /// <param name="useInitials">האם להשתמש באותיות ראשונות כשמות אמצעיים (כגון A., B.)</param>
    /// <returns>שם מלא אקראי הכולל שם פרטי, שמות אמצעיים ושם משפחה</returns>
    public string GenerateName(bool male = true, int middleCount = 0, bool useInitials = false)
    {
        string first = male ? GetRandom(Male) : GetRandom(Female);
        string last = GetRandom(Last);

        var middles = new List<string>();
        for (int i = 0; i < middleCount; i++)
        {
            if (useInitials)
                middles.Add(((char)('A' + rand.Next(0, 26))) + ".");
            else
                middles.Add(male ? GetRandom(Male) : GetRandom(Female));
        }

        return $"{first} {string.Join(" ", middles)} {last}".Trim();
    }

    /// <summary>
    /// מחזיר ערך אקראי מתוך רשימה מסוימת
    /// </summary>
    /// <param name="list">הרשימה שממנה ייבחר הערך</param>
    /// <returns>ערך אקראי מתוך הרשימה</returns>
    private string GetRandom(List<string> list) => list[rand.Next(list.Count)];
}
