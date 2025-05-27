using IdfOperation.Interfaces;

namespace IdfOperation.Idf;

public abstract class IdfSoldier : ISoldier
{
    public string Name { get; protected set; }
    public string Rank { get; set; }
    public string Assignment { get; set; }

    protected static readonly string[] Ranks =
    [
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
    ];

    protected static readonly string[] Assignments =
    [
        "Infantry",         // חיל רגלים
        "Intelligence",     // מודיעין
        "Engineering",      // חיל ההנדסה
        "Logistics",        // לוגיסטיקה
        "Medical",          // רפואה / חיל רפואה
        "Air Force",        // חיל האוויר
        "Pilot",            // טייס
        "Navy",             // חיל הים
        "Cyber",            // סייבר
        "Chief of Staff"    // רמטכ״ל (ראש המטה הכללי)
    ];

    protected IdfSoldier(string name, string rank, string assignment)
    {
        Name = name;
        Rank = rank;
        Assignment = assignment;
    }
}