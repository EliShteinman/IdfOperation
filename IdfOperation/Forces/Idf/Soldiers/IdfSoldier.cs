namespace IdfOperation.Forces.Idf.Soldiers;

public abstract class IdfSoldier : Soldier
{
    public string name { get; set; }
    public string rank { get; set; }
    public string assignment { get; set; }
    
    protected static string[] Ranks = new string[]
    {
        "Pvt.",         // טוראי
        "Cpl.",         // רב״ט
        "Sgt.",         // סמל
        "SSgt.",        // סמ״ר
        "Capt.",        // סרן
        "Maj.",         // רס״ן
        "Lt.Col.",      // סא״ל
        "Col.",         // אל״ם
        "Maj.Gen.",     // אלוף
        "Lt.Gen."       // רב־אלוף
    };
    
    protected static string[] Assignments = new string[]
    {
        "Infantry",         // חיל רגלים
        "Intelligence",     // מודיעין
        "Engineering",      // חיל ההנדסה
        "Logistics",        // לוגיסטיקה
        "Medical",          // רפואה / חיל רפואה
        "Air Force",        // חיל האוויר
        "Navy",             // חיל הים
        "Cyber",            // סייבר
        "Chief of Staff"    // רמטכ״ל (ראש המטה הכללי)
    };

    protected IdfSoldier(string name, string rank, string assignment)
    {
        this.name = name;
        this.rank = rank;
        this.assignment = assignment;
    }
}